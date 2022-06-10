using ModelSystemRPG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelSystemRPG
{
    public partial class Catalog : Form
    {
        Dictionary<int, ModelData> modelsData;
        List<int> modelsIdxSorted;
        DBHandler dbHandler;
        DataOperator dataOperator;

        // sort parameters in here
        public Catalog(string sortType = "", bool ascending = true)
        {
            InitializeComponent();

            //LoginSystem.getUserCategoriesLoaded(LoginSystem.user.userName);
            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName;
                LoginSystem.getUserCategoriesLoaded(LoginSystem.user.userName);
            }


            loadTheModelData();
            List<ModelData> modelList = new List<ModelData>(modelsData.Values);


            InitDataTable(sortType: sortType, ascending: ascending, modelList);
            setCheckBoxCheckedByDefault();
        }

        private void loadTheModelData()
        {
             dataOperator = new DataOperator();

            // get all models with data
            modelsData = dataOperator.getModels();
            dbHandler = new DBHandler();

            List<string> categoryNames = dbHandler.getCategoryNames();

            foreach (string name in categoryNames)
            {
                chListCategory.Items.Add(name);
            }

            // set env combobox options
            var envNames = dbHandler.getEnvironmentNames();
            envNames.Add("All");
            cboxEnvironment.DataSource = envNames;
            cboxEnvironment.Text = "All";
        }

        private void setCheckBoxCheckedByDefault()
        {
            for (int i = 0; i < chListCategory.Items.Count; i++)
            {
                chListCategory.SetItemCheckState(i, (true ? CheckState.Checked : CheckState.Unchecked));
            }
        }

        private void InitDataTable(string sortType, bool ascending, List<ModelData> modelList)
        {
            if (tableLayoutPanel1.Controls.Count != 0)
            {
                tableLayoutPanel1.Controls.Clear();
            }
            
            // idx of row
            int i = 0;

            // if sorted parameters are provided
            if (sortType == "categoryName")
            {
                modelList = Sorter.sortAlphabeticallyByCategory(models: modelsData, ascending: ascending);
            }
            else if(sortType == "modelName")
            {
                modelList = Sorter.sortAlphabeticallyByModel(models: modelsData, ascending: ascending);
            }

            // go through each model
            foreach(var model in modelList)
            {
                // get properties for the model
                var properties = model.getPropertiesList();
                // all properties in one string
                StringBuilder propertiesStr = new StringBuilder();

                // retrieve data and generate row for each model
                foreach(var property in properties)
                {
                    propertiesStr.Append(property.propertyName + ": " + property.propertyValue + "\n");
                }
                // create category information in string
                string categoryString =
                    $"Environment: \n\t {model.environmentName} \n Category name: \n\t {model.categoryName} \n Category description: \n\t {model.categoryDescription}";
                // Category button
                Button btnCategory = new Button();
                btnCategory.Text = model.categoryName;
                btnCategory.Name = "btnCategory" + i;
                btnCategory.Size = new System.Drawing.Size(150, 41);
                btnCategory.UseVisualStyleBackColor = true;
                // define button activity after clicking it
                btnCategory.Click += 
                    (s, e) => { 
                        ShowCategory showCategory = new ShowCategory(model.categoryName, model.categoryDescription, model.environmentName);
                        showCategory.Show();
                    };
                this.tableLayoutPanel1.Controls.Add(btnCategory, 0, i);


                // Model name label
                Label txtModelName = new Label();
                txtModelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
                txtModelName.AutoSize = true;
                txtModelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                txtModelName.Name = "btnModel" + i;
                txtModelName.Size = new System.Drawing.Size(106, 21);
                txtModelName.Text = model.modelName;
                txtModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.tableLayoutPanel1.Controls.Add(txtModelName, 1, i);


                // Properties button
                Button btnProperties = new Button();
                if(propertiesStr.ToString().Length > 30)
                {
                    btnProperties.Text = propertiesStr.ToString().Substring(0, 30) + "...";
                } else
                {
                    btnProperties.Text = propertiesStr.ToString();
                }
                btnProperties.Name = "btnProperties " + i;
                btnProperties.Size = new System.Drawing.Size(278, 41);
                btnProperties.Click +=
                    (s, e) =>
                    {
                        Properties properties = new Properties(model);
                        properties.Show();
                    };
                btnProperties.UseVisualStyleBackColor = true;
                this.tableLayoutPanel1.Controls.Add(btnProperties, 2, i);


                // Edit button
                Button btnEdit = new Button();
                btnEdit.Text = "Edit";
                btnEdit.Name = "btnEdit" + i;
                btnEdit.Size = new System.Drawing.Size(160, 41);
                btnEdit.UseVisualStyleBackColor = true;
                // if user is owner or admin then allow him to edit the model

                if ((LoginSystem.user != null) && ((LoginSystem.user.getCategoriesIds().Contains(model.categoryId)) || (LoginSystem.user.role == "Admin" || LoginSystem.user.role == "Moderator")))
                {
                        btnEdit.Enabled = true;
                } else
                {
                    btnEdit.Enabled = false;
                }
                btnEdit.Click +=
                    (s, e) => {
                        EditModel editModel = new EditModel(model);
                        editModel.Show();
                        this.Hide();
                    };
                this.tableLayoutPanel1.Controls.Add(btnEdit, 3, i);


                // Delete button
                Button btnDelete = new Button();
                btnDelete.Text = "Delete";
                btnDelete.Name = "btnDelete" + i;
                btnDelete.Size = new System.Drawing.Size(145, 41);
                btnDelete.UseVisualStyleBackColor = true;
                // if user is owner or admin then allow him to delete the model
                if (LoginSystem.user != null && (LoginSystem.user.getCategoriesIds().Contains(model.categoryId) || (LoginSystem.user.role == "Admin" || LoginSystem.user.role == "Moderator")))
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
                btnDelete.Click +=
                    (s, e) => {
                        dbHandler.deleteModel(model.modelId); 
                        // refresh Catalog form
                        Catalog catalog = new Catalog();
                        catalog.Show();
                        this.Hide();
                    };
                this.tableLayoutPanel1.Controls.Add(btnDelete, 4, i);

                // increment row count
                this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;
                // increment row number
                i++;
            }
        }

        private void btnSortByCategory_Click(object sender, EventArgs e)
        {
            bool dafuq = checkAscendingSort.Checked;
            if (checkAscendingSort.Checked)
            {
                Catalog catalog = new Catalog(sortType: "categoryName", ascending: true);
                catalog.Show();
                this.Hide();
            } else
            {
                Catalog catalog = new Catalog(sortType: "categoryName", ascending: false);
                catalog.Show();
                this.Hide();
            }
        }

        private void btnSortByModel_Click(object sender, EventArgs e)
        {
            if (checkAscendingSort.Checked)
            {
                Catalog catalog = new Catalog(sortType: "modelName", ascending: true);
                catalog.Show();
                this.Hide();
            }
            else
            {
                Catalog catalog = new Catalog(sortType: "modelName", ascending: false);
                catalog.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void btnFilterCategory_Click(object sender, EventArgs e)
        {
            List<string> categories = chListCategory.CheckedItems.Cast<string>().ToList();
            dataOperator = new DataOperator();
            Dictionary<int, ModelData> items = dataOperator.getModelsOfCategories(categories);
            InitDataTable(sortType: "", ascending: true, items.Values.ToList());
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            List<string> categories = chListCategory.CheckedItems.Cast<string>().ToList();

            string phrase = txtEnterName.Text;
            if(phrase != "")
            {
                Dictionary<int, ModelData> items = dataOperator.getModelsFilteredByName(phrase);
                InitDataTable(sortType: "", ascending: true, items.Values.ToList());
            } else
            {
                InitDataTable(sortType: "", ascending: true, dataOperator.getModels().Values.ToList());
            }
        }

        private void btnFilterByEnvironment_Click(object sender, EventArgs e)
        {
            if(cboxEnvironment.Text == "All")
            {
                List<ModelData> modelList = new List<ModelData>(modelsData.Values);
                InitDataTable(sortType: "", ascending: true, modelList);
                return;
            } else
            {
                List<string> categories = dbHandler.getCategoryNamesByEnvironment(cboxEnvironment.Text); 

                Dictionary<int, ModelData> items = dataOperator.getModelsOfCategories(categories);
                InitDataTable(sortType: "", ascending: true, items.Values.ToList());
            }
        }

    }
}

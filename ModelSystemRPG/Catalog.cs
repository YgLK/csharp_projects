﻿using ModelSystemRPG.Data;
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

        // sort parameters in here
        public Catalog(string sortType = "", bool ascending = true)
        {
            InitializeComponent();

            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }

            DataOperator dataOperator = new DataOperator();
            // get all models with data
            modelsData = dataOperator.getModels();
            dbHandler = new DBHandler();
            InitDataTable(sortType: sortType, ascending: ascending);
        }

        private void InitDataTable(string sortType, bool ascending)
        {

            // -- get models data --

            // i is compulsory to keep track of row number
            int i = 0;
            // add new rows

            // HERE SORTED MODELS DATA SHOULD BE SET
            // default case
            List<ModelData> modelList = new List<ModelData>(modelsData.Values);
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
                    "Category name: \n\t" + model.categoryName + "\n Category description: \n\t" + model.categoryDescription;
                // Category button
                Button btnCategory = new Button();
                btnCategory.Text = model.categoryName;
                btnCategory.Name = "btnCategory" + i;
                btnCategory.Size = new System.Drawing.Size(150, 41);
                btnCategory.UseVisualStyleBackColor = true;
                // define button activity after clicking it
                btnCategory.Click += 
                    (s, e) => { 
                        MessageBox.Show(categoryString); 
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
                txtModelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
                        MessageBox.Show("Properties of " + model.modelName + "\n\n" + propertiesStr.ToString());
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
                if (LoginSystem.user != null  && (LoginSystem.user.getCategoriesIds().Contains(model.categoryId) || LoginSystem.user.role == "Admin"))
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
                if (LoginSystem.user != null && (LoginSystem.user.getCategoriesIds().Contains(model.categoryId) || LoginSystem.user.role == "Admin"))
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
                //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
                //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            menu.Show();
            this.Hide();
        }
    }
}

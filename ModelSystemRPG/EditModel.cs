using ModelSystemRPG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelSystemRPG
{
    public partial class EditModel : Form
    {
        ModelData model;
        DBHandler dBHandler;
        // used to update properties
        DataOperator dataOperator;

        // num of rows
        int i = 0;

        public EditModel(ModelData _model)
        {
            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }


            dataOperator = new DataOperator();   
            model = dataOperator.getModels()[_model.modelId];
            dBHandler = new DBHandler();
            InitializeComponent();
            loadProperties();
        }



        public void loadProperties()
        {
            lblModelName.Text = model.modelName;
            lblCategoryName.Text = model.categoryName;

            // get properties for the model
            var properties = model.getPropertiesList();

            // retrieve data and generate row for each property
            foreach (var property in properties)
            {
                    // show property name
                    TextBox txtPropertyName = new TextBox();
                    txtPropertyName.Name = "txtPropertyName" + i;
                    txtPropertyName.Size = new System.Drawing.Size(311, 36);
                    txtPropertyName.Text = property.propertyName;
                    txtPropertyName.AutoSize = false;
                    txtPropertyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    this.tableLayoutPanel1.Controls.Add(txtPropertyName, 0, i);

                    // show property value
                    TextBox txtPropertyValue = new TextBox();
                    txtPropertyValue.Name = "txtPropertyValue" + i;
                    txtPropertyValue.Size = new System.Drawing.Size(311, 36);
                    txtPropertyValue.Text = property.propertyValue;
                    txtPropertyValue.AutoSize = false;
                    txtPropertyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    this.tableLayoutPanel1.Controls.Add(txtPropertyValue, 1, i);

                    // Delete button
                    Button btnDelete = new Button();
                    btnDelete.Text = "Delete";
                    btnDelete.Name = "btnDelete" + i;
                    // define button activity after clicking it - in this case delete property
                    btnDelete.Click +=
                        (s, e) => {
                            dBHandler.deleteModelProperty(property.propertyId);                             // <- it works, property is deleted, but Forms reload should be fixed
                            // reload properties edit view
                            EditModel editModel = new EditModel(model);
                            editModel.Show();
                            this.Hide();
                            MessageBox.Show("Property" + property.propertyName + " has been deleted.");
                        };
                    btnDelete.Size = new System.Drawing.Size(145, 36);
                    btnDelete.UseVisualStyleBackColor = true;
                    this.tableLayoutPanel1.Controls.Add(btnDelete, 2, i);


                    // increment row count
                    this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;
                    // increment row num
                    i++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }

        private void btnAddProp_Click(object sender, EventArgs e)
        {
            // show property name
            TextBox txtPropertyName = new TextBox();
            txtPropertyName.Name = "txtNewPropertyName " + i;
            txtPropertyName.Size = new System.Drawing.Size(311, 36);
            txtPropertyName.Text = "";
            txtPropertyName.AutoSize = false;
            txtPropertyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tableLayoutPanel1.Controls.Add(txtPropertyName, 0, i);

            // show property value
            TextBox txtPropertyValue = new TextBox();
            txtPropertyValue.Name = "txtNewPropertyValue" + i;
            txtPropertyValue.Size = new System.Drawing.Size(311, 36);
            txtPropertyValue.Text = "";
            txtPropertyValue.AutoSize = false;
            txtPropertyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tableLayoutPanel1.Controls.Add(txtPropertyValue, 1, i);

            // Delete button
            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Name = "btnNewDelete" + i;
            btnDelete.Enabled = false;
            // nie działa, powinno usuwać aktualny wiersz :/
            //btnDelete.Click +=        -- wyłączyłem ten przycisk, tak też można do tego podejść
            //            (s, e) => {
            //                this.Controls.Remove(txtPropertyName);
            //                this.Controls.Remove(txtPropertyValue);
            //                this.Controls.Remove(btnDelete);
            //            };
            btnDelete.Size = new System.Drawing.Size(145, 36);
            btnDelete.UseVisualStyleBackColor = true;
            this.tableLayoutPanel1.Controls.Add(btnDelete, 2, i);


            // increment row count
            this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;
            // increment row num
            i++;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            Dictionary<int, string> values = new Dictionary<int, string>();


            foreach (var control in this.tableLayoutPanel1.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    var txtProp = control as TextBox;
                    
                    // continue if property is blank
                    if(txtProp.Text == ""){
                        continue;
                    }
                    
                    // get index of row in tablelayout
                    int index = Int32.Parse(Regex.Match(txtProp.Name, @"\d+").Value);
                    if (txtProp.Name.Contains("PropertyName"))
                    {
                        names[index] = txtProp.Text.Trim();
                    } else if (txtProp.Name.Contains("PropertyValue"))
                    {
                        values[index] = txtProp.Text.Trim();
                    }
                }
            }

            // Delete all properties associated with this model
            dBHandler.deleteAllModelProperties(model.modelId);
            
            // Add all properties with data from TextBoxes
            foreach (int idx in names.Keys)
            {
                // omit not properly filled data
                if(names.ContainsKey(idx) && values.ContainsKey(idx) && names[idx] != "" && values[idx] != "")
                {
                    string pName = names[idx];
                    string pVal = values[idx];
                    Debug.WriteLine(names[idx] + " ---- " + values[idx] + "\n");
                    dBHandler.addModelProperty(model.modelId, pName, pVal);
                }
            }

            // voila
            MessageBox.Show("Changes has been saved.");
            //InitializeComponent();
            
            //Catalog catalog = new Catalog();
            //this.Close();
            //catalog.Show();
            EditModel editModel = new EditModel(model);
            this.Close();
            editModel.Show();
            //              W A R N I N G
            //---------------------------------------------------------------------------------------------------------
            // TODO:
            //  - po usunięciu property powinno się odświeżyć tablePanel i wyświetlać aktualne properties,
            //  po odświeżeniu jednak pozostają properties w takim stanie jak przed usunięciem/zmianą    // DONE
            // - system z użytkownikami
            //      - system logowania
            //      - dane modele może edytować // chyba // tylko wlasciciel kategorii
            // - filtracja podczas wyświetlania, sortowanie po nazwie/ilości properties etc.
            //---------------------------------------------------------------------------------------------------------

        }
    }
}

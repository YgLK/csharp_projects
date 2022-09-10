using ModelSystemRPG.Data;
using ModelSystemRPG.Data.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ModelSystemRPG
{
    public partial class AddModel : Form
    {
        DBHandler dbHandler;
        int propertyCount;
        List<Tuple<TextBox, TextBox>> defaultProperties;

        public AddModel()
        {
            InitializeComponent();
            
            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }

            dbHandler = new DBHandler();
            // store Textboxes of default properties
            defaultProperties = new List<Tuple<TextBox, TextBox>>();

            comboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            var envNames = dbHandler.getEnvironmentNames();
            comboBoxEnv.DataSource = envNames;
            comboBoxCat.DataSource = new List<string>() { "No permission." };
            loadFormComboBoxes();

            propertyCount = 0;

            // show default values of properties
            initDefaultProperties();
        }

        public void loadFormComboBoxes()
        {
            string environmentName = comboBoxEnv.Text;
            int userId = LoginSystem.user.userId;
            List<string> categoryNames;
            if(LoginSystem.user.role != "Admin" && LoginSystem.user.role != "Moderator")
            {
                categoryNames = dbHandler.getCategoryNamesByEnvironmentAndUserId(environmentName, userId);
            } else
            {
                categoryNames = dbHandler.getCategoryNamesByEnvironment(environmentName);
            }
            if(categoryNames.Count > 0)
            {
                comboBoxCat.DataSource = categoryNames;
            } else
            {
                comboBoxCat.DataSource = new List<string>() { "No permission." };
            }
        }

        public void initDefaultProperties()
        {
            string categoryName = comboBoxCat.Text;
            if(categoryName == "No permission.")
            {
                return;
            }
            int categoryId = dbHandler.getCategoryIdByName(categoryName);
            
            var categoryProperties = dbHandler.getCategoryPropertiesNames(categoryId);

            if (categoryProperties.Count > 0)
            {
                // retrieve data and generate row for each property
                foreach (var propertyName in categoryProperties)
                {
                    addProperty(propertyName: propertyName, propertyValue: "0",defaultProperty: true);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // open form
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if(comboBoxCat.Text == "No permission.")
            {
                MessageBox.Show("You don't have permission to add models to the categories in this environment. \nCreate new category or try again later.");
                return;
            }
            // model data
            string categoryName = comboBoxCat.Text;
            string modelName = txtCategoryDescription.Text;
            if(categoryName == "" || modelName == "")
            {
                MessageBox.Show("You have to fill all the fields before adding new model.");
                return;
            }

            int categoryId = dbHandler.getCategoryIdByName(categoryName);

            if (dbHandler.getModelNames().Contains(modelName))
            {
                MessageBox.Show("Model " + modelName + " already exists. Choose different name for your model!");
                return;
            }

            // check if all default properties are filled
            foreach(var defProperty in defaultProperties)
            {
                if(defProperty.Item1.Text.Trim() == "" || defProperty.Item2.Text.Trim() == "")
                {
                    MessageBox.Show("All default properties must be set. Try again.");
                    return;
                }
            }

            // add model to db
            dbHandler.addModel(modelName, categoryId);

            int modelId = dbHandler.getModelIdx(categoryName, modelName);


            for (int i = 0; i <= flowLayoutPanel1.Controls.Count; i++)
            {
                string txtName = "txtPropertyName" + i.ToString();
                string txtValue = "txtPropertyValue" + i.ToString();

                string propertyKey = "";
                string propertyValue = "";

                if (flowLayoutPanel1.Controls.ContainsKey(txtName) && (flowLayoutPanel1.Controls.ContainsKey(txtValue)))
                {
                    TextBox txtBoxName = flowLayoutPanel1.Controls[txtName] as TextBox;
                    TextBox txtBoxValue = flowLayoutPanel1.Controls[txtValue] as TextBox;

                    if (txtBoxName != null && txtBoxValue != null && txtBoxName.Text != "" && txtBoxValue.Text != "")
                    {
                        propertyKey = txtBoxName.Text;
                        propertyValue = txtBoxValue.Text;
                        dbHandler.addModelProperty(modelId, propertyKey, propertyValue);
                    }
                }
            }
            
            MessageBox.Show("Model \'" + modelName + "\' has been added.");

            // get back to the menu
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            addProperty();
        }

        private void addProperty(string propertyName = "", string propertyValue = "", bool defaultProperty = false)
        {
            // create next property name textbox
            TextBox tbName = new TextBox();
            tbName.Text = propertyName;
            tbName.AutoSize = false;
            tbName.Size = new System.Drawing.Size(283, 27);
            tbName.Name = "txtPropertyName" + propertyCount.ToString();

            // create value textbox according to the property name
            TextBox tbValue = new TextBox();
            tbValue.Text = propertyValue;
            tbValue.AutoSize = false;
            tbValue.Size = new System.Drawing.Size(194, 27);
            tbValue.Name = "txtPropertyValue" + propertyCount.ToString();


            if (defaultProperty)
            {
                tbName.Enabled = false;
                tbName.BackColor = Color.Yellow;
                defaultProperties.Add(Tuple.Create(tbName, tbValue));
            }
            
            // add textboxes to the panel
            flowLayoutPanel1.Controls.Add(tbName);
            flowLayoutPanel1.Controls.Add(tbValue);
            propertyCount++;
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            propertyCount = 0;
            // show default values of properties
            initDefaultProperties();
        }

        private void comboBoxEnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFormComboBoxes();
        }
    }
}

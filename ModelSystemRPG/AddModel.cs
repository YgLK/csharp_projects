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

        public AddModel()
        {
            InitializeComponent();
            dbHandler = new DBHandler();
            var names = dbHandler.getCategoryNames();
            comboBoxCat.DataSource = names;
            propertyCount = 1;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            //// open form
            //Menu menu = new Menu();
            //menu.Show();
            //this.Hide();

            // test if json parses properly
            string propertyJsonString = dbHandler.getDbContext().Models.Select(e => e.PropertiesJson).ToList()[0];
            //Parse the json object
            JObject jsonObject = JObject.Parse(propertyJsonString);
            Debug.WriteLine(jsonObject);

            foreach(var x in jsonObject)
            {
                Debug.WriteLine("Key:" + x.Key + "\nValue:" + x.Value);
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            // model data
            string categoryName = comboBoxCat.Text;
            string modelName = txtCategoryDescription.Text;
            int categoryId = dbHandler.getCategoryIdByName(categoryName);

            //Create properties
            var properties = new
            {
                surface = @"100",
                tree_count = "my_username",
                Password = "my_password",
                SourceDir = "/export/zip/mypath/",
                FileName = "my_file.zip"
            };

            // convert properties to string
            string jsonData = JsonConvert.SerializeObject(properties);

            // add model to the database
            dbHandler.addModel(modelName, categoryId, jsonData);
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            // create next property name textbox
            TextBox tbName = new TextBox();
            tbName.Text = "";
            tbName.AutoSize = false;
            tbName.Size = new System.Drawing.Size(248, 23);
            tbName.Name = "txtPropertyName"+ propertyCount;

            // create value textbox according to the property name
            TextBox tbValue = new TextBox();
            tbValue.Text = "";
            tbValue.AutoSize = false;
            tbValue.Size = new System.Drawing.Size(170, 23);
            tbValue.Name = "txtPropertyValue" + propertyCount;

            // add textboxes to the panel
            flowLayoutPanel1.Controls.Add(tbName);
            flowLayoutPanel1.Controls.Add(tbValue);
            propertyCount++;
        }
    }
}

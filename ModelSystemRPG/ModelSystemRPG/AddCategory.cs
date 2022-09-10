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
    public partial class AddCategory : Form
    {
        DBHandler dbHandler;
        int propertyCount;

        public AddCategory()
        {
            InitializeComponent();
            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }
            
            dbHandler = new DBHandler();
            cboxEnvironment.DataSource = dbHandler.getEnvironmentNames();

            cboxEnvironment.Enabled = true;
            lblNewEnvName.Visible = false;
            txtNewEnvName.Visible = false;
            txtNewEnvName.Enabled = false;
        }



        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // add new category
            string categoryName = txtCategoryName.Text;
            string description = txtCategoryDescription.Text;
            string environment = "";
            if(checkBox1.Checked == true)
            {
                environment = txtNewEnvName.Text;
                if (dbHandler.getEnvironmentNames().Contains(environment))
                {
                    MessageBox.Show("Provided environment already exists. Try again.");
                    return;
                }
            }else
            {
                environment = cboxEnvironment.Text;
            }

            int userId = LoginSystem.user.userId;
            if(categoryName == "" || description == "" || environment == "" || userId < 0)
            {
                MessageBox.Show("Fill all fields before adding new category!");
                return;
            } else if (dbHandler.getCategoryNames().Contains(categoryName))
            {
                MessageBox.Show("Category " + categoryName + " already exists. Try again.");
                return;
            }
            dbHandler.addCategory(categoryName, userId, description, environment);


            // add default category properties to the table
            for (int i = 0; i < flowLayoutPanel1.Controls.Count - 1; i += 2)
            {
                string propertyName = flowLayoutPanel1.Controls[i].Text;
                string propertyType = flowLayoutPanel1.Controls[i + 1].Text;
                if(propertyName != "")
                {
                    dbHandler.addCategoryProperty(categoryName, propertyName, propertyType);
                }
            }

            MessageBox.Show("New category has been added.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // open form
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            addProperty();
        }


        private void addProperty(string propertyName = "", string propertyValue = "")
        {
            // create next property name textbox
            TextBox tbName = new TextBox();
            tbName.Text = propertyName;
            tbName.AutoSize = false;
            tbName.Size = new System.Drawing.Size(283, 27);
            tbName.Name = "txtPropertyName" + propertyCount.ToString();

            // create type combobox according to the property name            
            ComboBox tbType = new ComboBox();
            tbType.Text = propertyValue;
            tbType.AutoSize = false;
            tbType.DataSource = new List<string>() { "int", "string" };
            tbType.Size = new System.Drawing.Size(194, 27);
            tbType.Name = "cbBoxPropertyType" + propertyCount.ToString();
            // -------------
            tbType.Visible = false;
            // -------------

            // add textboxes to the panel
            flowLayoutPanel1.Controls.Add(tbName);
            flowLayoutPanel1.Controls.Add(tbType);
            propertyCount++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                cboxEnvironment.Enabled = false;
                lblNewEnvName.Visible = true;
                txtNewEnvName.Visible = true;
                txtNewEnvName.Enabled = true;
            }
            else
            {
                cboxEnvironment.Enabled = true;
                lblNewEnvName.Visible = false;
                txtNewEnvName.Visible = false;
                txtNewEnvName.Enabled = false;
            }
        }
    }
}

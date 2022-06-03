using ModelSystemRPG.Data;
using ModelSystemRPG.Data.Models;
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
    public partial class ManageUsers : Form
    {
        DBHandler dbHandler;
        DataOperator dataOperator;

        public ManageUsers()
        {
            dbHandler = new DBHandler();
            dataOperator = new DataOperator();

            InitializeComponent();
            cboxDelUser.DataSource = dbHandler.getUsersNames();
            txtNewPassword.PasswordChar = '*';
            txtRepeatPassword.PasswordChar = '*';
            comboBox1.DataSource = new List<string>() { "Admin", "Moderator", "User" };
            loadForm();

            // hide Admin panel
            if(LoginSystem.user.role != "Admin")
            {
                comboBox1.Enabled = false;
                comboBox1.Visible = false;
                cboxDelUser.Enabled = false;
                cboxDelUser.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnDeleteUser.Enabled = false;
                btnDeleteUser.Visible = false;
            }
            lblRole.Text = LoginSystem.user.role;
            loadCategoriesList();
        }

        public void loadCategoriesList()
        {
            List<string> categoryNames;
            if(LoginSystem.user.role == "Admin" || LoginSystem.user.role == "Moderator")
            {
                categoryNames = dbHandler.getCategoryNames();
            } else
            {
                categoryNames = dbHandler.getUsersCategoriesNames(LoginSystem.user.userId);
            }
            // add names to check list 
            foreach (string name in categoryNames)
            {
                checkListBoxDelCategories.Items.Add(name);
            }
        }

        public void loadForm()
        {
            string userName = cboxDelUser.Text;
            User user = dbHandler.getUserByUsername(userName);
            comboBox1.Text = user.Role;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SystemRPGContext rpgDbContext = new SystemRPGContext();
            try
            {
                var userToDel = rpgDbContext.Users.Where(e => e.Username == cboxDelUser.Text).Select(e => e).ToArray()[0];
                rpgDbContext.Remove(userToDel);
                rpgDbContext.SaveChanges();
                MessageBox.Show("User has been deleted.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error. Couldn't delete the user.");
                Debug.WriteLine(exception.Message);
            }
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void cboxDelUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private bool savePassword()
        {
            if(txtNewPassword.Text != "" && txtRepeatPassword.Text != "")
            {
                if(txtNewPassword.Text != txtRepeatPassword.Text)
                {
                    return false;
                } else
                {
                    User userToChange = dbHandler.getUserByUsername(cboxDelUser.Text);
                    string password = txtNewPassword.Text;
                    string encryptedPassword = PasswordEncryptor.EncryptPlainTextToCipherText(password);
                    userToChange.Password = encryptedPassword;
                    dbHandler.getDbContext().SaveChanges();
                    return true;
                }
            } 
            return false;
        }

        private bool saveRole()
        {
            User userToChange = dbHandler.getUserByUsername(cboxDelUser.Text);
            userToChange.Role = comboBox1.Text;
            dbHandler.getDbContext().SaveChanges();
            return true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(LoginSystem.user.role == "Admin")
            {
                bool roleSaved = saveRole();
                bool passwordSaved = savePassword();
                if(passwordSaved)
                {
                    MessageBox.Show("Changes has been saved.");
                } else
                {
                    MessageBox.Show("Role saved. Unfortunately, password wasn't asccepted. Try again later.");
                }
            } else
            {
                bool passwordSaved = savePassword();
                if (passwordSaved)
                {
                    MessageBox.Show("New password has been saved.");
                }
                else
                {
                    MessageBox.Show("Unfortunately, password wasn't asccepted. Try again later.");
                }
            }
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            // checked categories
            List<string> categories = checkListBoxDelCategories.CheckedItems.Cast<string>().ToList();
            if(categories.Count == 0)
            {
                MessageBox.Show("No categories where chosen to delete.");
                return;
            }

            // delete categories
            foreach(string catName in categories)
            {
                dbHandler.deleteCategory(catName);
            }

            MessageBox.Show("Chosen categories are deleted.");
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}

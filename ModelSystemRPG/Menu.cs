using ModelSystemRPG.Data;
using System.Diagnostics;

namespace ModelSystemRPG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            // ------ TESTING ENVIRONMENT -------------
            //Debug.WriteLine("Array dawaj: \n");
            //foreach(string x in (new DBHandler()).getCategoryNames())
            //{
            //    Debug.WriteLine(x);
            //}
            txtPassword.PasswordChar = '*';
            if(LoginSystem.user != null)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
                btnRegister.Enabled = false;
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (LoginSystem.user == null)
            {
                MessageBox.Show("You must be logged in to add a category.");
            } else
            {
                // open form
                AddCategory addCategory = new AddCategory();
                addCategory.Show();
                this.Hide();
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if(LoginSystem.user == null)
            {
                MessageBox.Show("You must be logged in to add a model.");
            } else
            {
                // open form
                AddModel addModel = new AddModel();
                addModel.Show();
                this.Hide();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // open form
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // open form
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if(username != "" && password != "")
            {
                if(LoginSystem.LogIn(username, password))
                {
                    lblLoggedInUsername.Text = LoginSystem.user.userName;
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                    btnRegister.Enabled = false;
                    btnLogout.Visible = true;
                    btnLogout.Enabled = true;
                } else
                {
                    MessageBox.Show("Incorrect password. Try different one.");
                }
            } else
            {
                MessageBox.Show("Enter your username and password firstly.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            btnRegister.Enabled = true;
            btnLogout.Visible = false;
            lblLoggedInUsername.Text = "Unknown";
            LoginSystem.LogOut();
        }
    }
}
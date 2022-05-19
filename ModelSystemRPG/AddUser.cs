using ModelSystemRPG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelSystemRPG
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPasswordRepeat.PasswordChar = '*';
            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName; 
            }
            cboxRole.DataSource = new[]{ "User", "Admin" };
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string role = cboxRole.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string passwordRepeated = txtPasswordRepeat.Text;
            if(password != passwordRepeated)
            {
                MessageBox.Show("Passwords are not equal. Try again.");

            } else if (username != "" && role != "" && email != "" && password != "")
            {
                DBHandler dbHandler = new DBHandler();
                dbHandler.addUser(username, role, email, password);
                MessageBox.Show("New user has been added.");
            } else
            {
                MessageBox.Show("Couldn't add new user. Fill compulsory data first.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // open form
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

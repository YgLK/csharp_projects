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
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            // user role is set by default - only admin can change your role
            string role = "User";
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string passwordRepeated = txtPasswordRepeat.Text;
            if(password != passwordRepeated)
            {
                MessageBox.Show("Passwords are not equal. Try again.");
            } else if (username != "" && role != "" && email != "" && password != "")
            {

                DBHandler dbHandler = new DBHandler();
                if (dbHandler.getUsersNames().Contains(username))
                {
                    MessageBox.Show("User " + username + " already exists. Choose different username.");
                    return;
                }
                string encryptedPassword = PasswordEncryptor.EncryptPlainTextToCipherText(password);
                dbHandler.addUser(username, role, email, encryptedPassword);
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

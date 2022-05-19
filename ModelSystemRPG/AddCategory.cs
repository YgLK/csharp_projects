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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
            if (LoginSystem.user != null)
            {
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DBHandler dbHandler = new DBHandler();
            // add new category
            string categoryName = txtCategoryName.Text;
            string description = txtCategoryDescription.Text;
            int userId = LoginSystem.user.userId;
            dbHandler.addCategory(categoryName, userId, description);
            MessageBox.Show("New category has been inserted.");
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

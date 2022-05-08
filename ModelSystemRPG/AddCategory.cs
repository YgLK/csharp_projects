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
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DBHandler dbHandler = new DBHandler();
            // add new category
            string categoryName = txtCategoryName.Text;
            string description = txtCategoryDescription.Text;
            dbHandler.addCategory(categoryName, userId: 2, description);
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

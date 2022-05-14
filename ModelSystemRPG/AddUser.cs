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
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DBHandler dbHandler = new DBHandler();
            dbHandler.addUser("nowy20", "Admin", "nowy20@gmail.com");
            MessageBox.Show("New user has been inserted.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // open form
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}

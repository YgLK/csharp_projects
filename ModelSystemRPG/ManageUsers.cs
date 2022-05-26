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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            DBHandler dbHandler = new DBHandler();

            InitializeComponent();
            cboxDelUser.DataSource = dbHandler.getUsersNames();
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
    }
}

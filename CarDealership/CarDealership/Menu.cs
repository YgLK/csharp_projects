using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void dreamCarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DreamCarForm dreamCar = new DreamCarForm();
            dreamCar.Show();
        }

        private void newCarAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellCarForm sellCar = new SellCarForm();
            sellCar.Show();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnRemoveRes bookTestDrive = new btnRemoveRes();
            bookTestDrive.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

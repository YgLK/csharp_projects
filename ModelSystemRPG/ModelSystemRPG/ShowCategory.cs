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
    public partial class ShowCategory : Form
    {
        public ShowCategory(string catName, string catDescription, string catEnvironment)
        {
            InitializeComponent();
            lblCatName.Text = catName;
            lblDescription.Text = catDescription;
            lblEnvironment.Text = catEnvironment;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

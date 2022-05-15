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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
            InitDataTable();

        }

        private void InitDataTable()
        {
            // add new rows
            for (int i = 1; i < 40; i++)
            {
                // Category button
                Button btnCategory = new Button();
                btnCategory.Text = "Kategoria " + i;
                btnCategory.Name = "btnCategory" + i;
                btnCategory.Size = new System.Drawing.Size(150, 41);
                btnCategory.UseVisualStyleBackColor = true;
                this.tableLayoutPanel1.Controls.Add(btnCategory, 0, i);


                // Model name label
                Label txtModelName = new Label();
                txtModelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
                txtModelName.AutoSize = true;
                txtModelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                txtModelName.Name = "txtModelName" + i;
                txtModelName.Size = new System.Drawing.Size(106, 21);
                txtModelName.Text = "Model name " + i;
                txtModelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                this.tableLayoutPanel1.Controls.Add(txtModelName, 1, i);


                // Properties button
                Button btnProperties = new Button();
                btnProperties.Text = "Cechy";
                btnProperties.Name = "btnProperties1";
                btnProperties.Size = new System.Drawing.Size(278, 41);
                btnProperties.UseVisualStyleBackColor = true;
                this.tableLayoutPanel1.Controls.Add(btnProperties, 2, i);


                // Edit button
                Button btnEdit = new Button();
                btnEdit.Text = "Edit " + i;
                btnEdit.Name = "btnEdit" + i;
                btnEdit.Size = new System.Drawing.Size(160, 41);
                btnEdit.UseVisualStyleBackColor = true;
                this.tableLayoutPanel1.Controls.Add(btnEdit, 3, i);


                // Delete button
                Button btnDelete = new Button();
                btnDelete.Text = "Delete " + i;
                btnDelete.Name = "btnDelete" + i;
                btnDelete.Size = new System.Drawing.Size(145, 41);
                btnDelete.UseVisualStyleBackColor = true;
                this.tableLayoutPanel1.Controls.Add(btnDelete, 4, i);


                // increment row count
                this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;

                //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

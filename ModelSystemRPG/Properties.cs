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
    public partial class Properties : Form
    {
        ModelData model; 

        public Properties(ModelData modelData)
        {
            InitializeComponent();
            model = modelData;
            loadProperties(modelData);
        }

        public void loadProperties(ModelData modelData)
        {
            // get properties for the model
            var properties = model.getPropertiesList();

            // retrieve data and generate row for each model
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int j=0; j < properties.Count; j++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
                this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;
            }

            int i = 0;

            foreach (var property in properties)
            {
                // Model name label
                Label txtPropertyName = new Label();
                txtPropertyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
                txtPropertyName.AutoSize = true;
                txtPropertyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                txtPropertyName.Name = "txtProperty" + i;
                txtPropertyName.Size = new System.Drawing.Size(106, 21);
                txtPropertyName.Text = property.propertyName;
                txtPropertyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.tableLayoutPanel1.Controls.Add(txtPropertyName, 0, i);

                // Model name label
                Label txtPropertyValue = new Label();
                txtPropertyValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
                txtPropertyValue.AutoSize = true;
                txtPropertyValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                txtPropertyValue.Name = "txtProperty" + i;
                txtPropertyValue.Size = new System.Drawing.Size(106, 21);
                txtPropertyValue.Text = property.propertyValue;
                txtPropertyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.tableLayoutPanel1.Controls.Add(txtPropertyValue, 1, i);


                i++;
                // increment row count
                this.tableLayoutPanel1.RowCount = this.tableLayoutPanel1.RowCount + 1;
            }



            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelSystemRPG;
using ModelSystemRPG.Data;

namespace ModelSystemRPG
{
    public partial class ListItem : UserControl
    {
        DBHandler dBHandler;
        
        
        public ListItem()
        {
            InitializeComponent();
            dBHandler = new DBHandler();
        }

        #region Properties

        private string _categoryName = "";
        private string _modelName = "";
        // modelId will be used for deleting and searching for properties
        private int _modelId = -1;


        [Category("Custom props")]
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; btnCategory.Text = value; }
        }


        [Category("Custom props")]
        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; txtModel.Text = value; }
        }

        [Category("Custom props")]
        public int ModelId
        {
            get { return _modelId; }
            set { _modelId = value; }
        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dBHandler.deleteModel(_modelId);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("informacje kategorii: nazwa, description, properties");
        }
    }
}

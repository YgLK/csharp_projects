using ModelSystemRPG.Data;
using System.Diagnostics;

namespace ModelSystemRPG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // open form
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
            this.Hide();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            // open form
            AddModel addModel = new AddModel();
            addModel.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // open form
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        // test environment
        private void btnTest_Click(object sender, EventArgs e)
        {
            DBHandler dbHandler = new DBHandler();
            var dictProp = dbHandler.getModelProperties(1);
            Debug.WriteLine("Dict: \n" + string.Join(Environment.NewLine, dictProp));
            string stringProp = dbHandler.toStringModelProperties(dictProp);
            Debug.WriteLine("String: \n" + stringProp);
        }
    }
}
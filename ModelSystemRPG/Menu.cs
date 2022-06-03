using ModelSystemRPG.Data;
using System.Diagnostics;

namespace ModelSystemRPG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            

            txtPassword.PasswordChar = '*';
            if(LoginSystem.user != null)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
                btnRegister.Enabled = false;
                btnLogout.Visible = true;
                btnLogout.Enabled = true;
                lblLoggedInUsername.Text = LoginSystem.user.userName;
            }

            loadNewestModels();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (LoginSystem.user == null)
            {
                MessageBox.Show("You must be logged in to add a category.");
            } else
            {
                // open form
                AddCategory addCategory = new AddCategory();
                addCategory.Show();
                this.Hide();
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if(LoginSystem.user == null)
            {
                MessageBox.Show("You must be logged in to add a model.");
            } else
            {
                // open form
                AddModel addModel = new AddModel();
                addModel.Show();
                this.Hide();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // open form
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // open form
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            
            if(username != "" && password != "")
            {
                if(LoginSystem.LogIn(username, password))
                {
                    lblLoggedInUsername.Text = LoginSystem.user.userName;
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                    btnRegister.Enabled = false;
                    btnLogout.Visible = true;
                    btnLogout.Enabled = true;
                } else
                {
                    MessageBox.Show("Incorrect login data. Try again.");
                }
            } else
            {
                MessageBox.Show("Enter your username and password first.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            btnRegister.Enabled = true;
            btnLogout.Visible = false;
            lblLoggedInUsername.Text = "Unknown";
            LoginSystem.LogOut();
        }

        public void loadNewestModels()
        {
            DataOperator dataOperator = new DataOperator();
            Dictionary<int, ModelData> newestModels = dataOperator.getTheNewestModels();

            List<int> keys = newestModels.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                ModelData model = newestModels.Values.ToList()[i];

                // create category information in string
                string categoryString =
                    $"Environment: \n\t {model.environmentName} \n Category name: \n\t {model.categoryName} \n Category description: \n\t {model.categoryDescription}";
                // Category button
                Button btnCategory = new Button();
                btnCategory.Text = model.categoryName;
                btnCategory.Name = "btnCategory" + i;
                btnCategory.Size = new System.Drawing.Size(150, 41);
                btnCategory.UseVisualStyleBackColor = true;
                // define button activity after clicking it
                btnCategory.Click +=
                    (s, e) => {
                        ShowCategory showCategory = new ShowCategory(model.categoryName, model.categoryDescription, model.environmentName);
                        showCategory.Show();
                    };
                this.tableLayoutPanel1.Controls.Add(btnCategory, 0, i);
                btnCategory.Dock = DockStyle.Fill;

                // Model name label
                Label txtModelName = new Label();
                txtModelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
                txtModelName.AutoSize = true;
                txtModelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                txtModelName.Name = "btnModel" + i;
                txtModelName.Size = new System.Drawing.Size(106, 21);
                txtModelName.Text = model.modelName;
                txtModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.tableLayoutPanel1.Controls.Add(txtModelName, 1, i);


                // Properties button
                Button btnProperties = new Button();
                btnProperties.Name = "btnProperties " + i;
                btnProperties.Text = "properties";
                btnProperties.Font = new Font("Tahoma", 9, FontStyle.Bold | FontStyle.Italic);
                btnProperties.Size = new System.Drawing.Size(278, 60);
                btnProperties.Click +=
                    (s, e) =>
                    {
                        Properties showProperties = new Properties(model);
                        showProperties.Show();
                    };
                btnProperties.UseVisualStyleBackColor = true;
                btnCategory.Dock = DockStyle.Fill;
                this.tableLayoutPanel1.Controls.Add(btnProperties, 2, i);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginSystem.user == null)
            {
                MessageBox.Show("Only logged-in users can access User panel");
                return;
            }
            ManageUsers manageUsers = new ManageUsers();
            this.Hide();
            manageUsers.Show();
        }
    }
}
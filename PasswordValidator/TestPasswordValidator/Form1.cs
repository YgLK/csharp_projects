namespace TestPasswordValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRegister.Enabled = false;
            txtPassword.PasswordChar = '*';
            passwordValidator1.TxtBoxPasswordProp = txtPassword;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (passwordValidator1.CheckPassword())
            {
                btnRegister.Enabled = true;
            } else
            {
                btnRegister.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Enter the username!");
            } else
            {
                MessageBox.Show("Password has been accepted.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
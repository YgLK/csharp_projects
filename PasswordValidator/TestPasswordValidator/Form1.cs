namespace TestPasswordValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRegister.Enabled = false;
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
            MessageBox.Show("Password has been accepted.");
        }
    }
}
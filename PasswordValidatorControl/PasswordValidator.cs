using System.ComponentModel;
using System.Text.RegularExpressions;

namespace PasswordValidatorControl
{
    public partial class PasswordValidator : UserControl
    {

        private TextBox txtBoxPassword;
        private int minCharCount;
        private int minSpecCharCount;
        private int minCapLetterCount;
        private int minDigitCount;


        public TextBox TxtBoxPasswordProp
        {
            get { return txtBoxPassword; }
            set { txtBoxPassword = value; }
        }
        public int MinCharCountProp
        {
            get { return minCharCount; }
            set { minCharCount = value; }
        }
        public int MinSpecCharCountProp
        {
            get { return minSpecCharCount; }
            set { minSpecCharCount = value; }
        }
        public int MinCapLetterCountProp
        {
            get { return minCapLetterCount; }
            set { minCapLetterCount = value; }
        }

        public int MinDigitCountProp
        {
            get { return minDigitCount; }
            set { minDigitCount = value; }
        }
        

        public PasswordValidator()
        {
            InitializeComponent();

            //setLabels();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            setLabels();
        }

        private void setLabels()
        {
            lblMinChar.Text = "at least " + minCharCount + " character";
            if (minCharCount > 1)
            {
                lblMinChar.Text += "s";
            }

            lblMinSpecChar.Text = "at least " + minSpecCharCount + " special character";
            if (minSpecCharCount > 1)
            {
                lblMinSpecChar.Text += "s";
            }

            lblCapitalLetter.Text = "at least " + minCapLetterCount + " capital letter";
            if (minCapLetterCount > 1)
            {
                lblCapitalLetter.Text += "s";
            }

            lblMinDigit.Text = "at least " + minDigitCount + " digit";
            if (minDigitCount > 1)
            {
                lblMinDigit.Text += "s";
            }
        }

        public bool CheckPassword()
        {
            int fullfilledConditions = 0;

            if (isPasswordLengthCorrect())
            {
                boolCharCount.Text = "True";
                fullfilledConditions += 1;
            } else
            {
                boolCharCount.Text = "False";
            }

            if (isSpecialCharCountCorrect())
            {
                boolSpecCharCount.Text = "True";
                fullfilledConditions += 1;
            } else
            {
                boolSpecCharCount.Text = "False";
            }

            if (isCapitalLettersCountCorrect())
            {
                boolCapitalLetterCount.Text = "True";
                fullfilledConditions += 1;
            } else
            {
                boolCapitalLetterCount.Text = "False";
            }

            if (isDigitCountCorrect())
            {
                boolDigitCount.Text = "True";
                fullfilledConditions += 1;
            } else
            {
                boolDigitCount.Text = "False";
            }


            // return if password is valid
            if (fullfilledConditions == 4)
            {
                return true;
            }
            return false;

        }

        private bool isPasswordLengthCorrect()
        {  
            int length = txtBoxPassword.Text.Length;
            if(length >= minCharCount)
            {
                return true;
            }
            return false;
        }

        private bool isSpecialCharCountCorrect()
        {
            int specialCharCount = Regex.Matches(txtBoxPassword.Text, "[~!@#$%^&*()_+{}:\"<>?]").Count;
            if (specialCharCount >= minSpecCharCount)
            {
                return true;
            }
            return false;
        }

        private bool isCapitalLettersCountCorrect()
        {
            int capitalLettersCount = txtBoxPassword.Text.Count(c => char.IsUpper(c));
            if (capitalLettersCount >= minCapLetterCount)
            {
                return true;
            }
            return false;
        }

        private bool isDigitCountCorrect()
        {
            int digitCount = txtBoxPassword.Text.Count(c => Char.IsNumber(c));
            if (digitCount >= minDigitCount)
            {
                return true;
            }
            return false;
        }
    }
}
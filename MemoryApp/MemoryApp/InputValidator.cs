using System;
using System.Windows.Forms;


namespace MemoryApp
{
    class InputValidator
    {


        static public int validateInteger(String strInteger)
        {
            int number = 0;

            try
            {
                number = Convert.ToInt32(strInteger);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message + "\n String cannot be casted to integer.");
                return -1;
            }
            return number;
        }


        static public double validateDouble(String price)
        {
            double doubleNumber = 0;

            try
            {
                doubleNumber = Convert.ToDouble(price);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message + "\n String cannot be casted to double.");
                return -1;
            }
            return doubleNumber;
        }

        static public string validateString(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                MessageBox.Show("No blank fields are allowed.");
                return "";
            }
            return str;
        }
    }
}

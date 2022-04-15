using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    class InputValidator
    {


        static public int validateYear(String year)
        {
           int yearNumber = 0;

            try
            {
                yearNumber = Convert.ToInt32(year);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message + "\n Year must be integer.");
                return -1;
            }
            return yearNumber;
        }


        static public double validatePrice(String price)
        {
            double priceNumber = 0;

            try
            {
                priceNumber = Convert.ToDouble(price);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message + "\n Price must be decimal number.");
                return -1;
            }
            return priceNumber;
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

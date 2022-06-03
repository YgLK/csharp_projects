using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class SellCarForm : Form
    {
        string pictureSourcePath = "";
        string pictureDestinationPath = "";


        public SellCarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            priceTextBox.Text = "";
            engineTextBox.Text = "";
            colorTextBox.Text = "";
        }

        private void addOfferButton_Click(object sender, EventArgs e)
        {
            string make = InputValidator.validateString(makeTextBox.Text);
            string model = InputValidator.validateString(modelTextBox.Text);
            string engine = InputValidator.validateString(engineTextBox.Text);
            string color = InputValidator.validateString(colorTextBox.Text);
            int year = InputValidator.validateYear(yearTextBox.Text);
            double price = InputValidator.validatePrice(priceTextBox.Text);

            if(make == "" || model == "" ||  engine == "" || color == "")
            {
                MessageBox.Show("No blank fields are allowed! Fill the compulsory data.");
                return;
            }

            // add data to set and check if all fields are filled
            HashSet<string> checkData = new HashSet<string> { make, model, year.ToString(), engine, color, price.ToString() };


            // if data is not properly filled return
            if (checkData.Contains("") || checkData.Contains("-1"))
            {
                return;
            }

            string record = year + "," + make + "," + model + "," + price + "," + color + "," + engine;

            File.AppendAllText(@".\Data\carData_test.txt",
                   record + Environment.NewLine);


            // upload picture associated with offer
            if (pictureDestinationPath == "" || pictureSourcePath == "")
            {
                MessageBox.Show("No picture is uploaded. Default one is associated with this offer.");
            } 
            else 
            {
                // if picture already exists continue
                try
                {
                    System.IO.File.Copy(pictureSourcePath, pictureDestinationPath);
                }
                catch(IOException exception)
                {
                    MessageBox.Show(exception.ToString(), "\n Picture associated with this offer already exists.");
                }
            }

            MessageBox.Show("New offer has been added.");
        }


        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // file types, that will be allowed to upload
            openFileDialogCarImage.Filter = "Images (*.png) | *.png"; 
            // allow/deny user to upload more than one file at a time
            openFileDialogCarImage.Multiselect = false; 
            // if user clicked OK
            if (openFileDialogCarImage.ShowDialog() == DialogResult.OK) 
            {
                // get name of file
                String path = openFileDialogCarImage.FileName; 
                carImage.ImageLocation = path;
                string color = colorTextBox.Text.Replace(" ", "");
                string model = modelTextBox.Text.Replace(" ", "");
                string filename = color + model + ".png";
                string carImagesDirPath = @".\CarImages\" + filename;

                pictureSourcePath = path;
                pictureDestinationPath = carImagesDirPath;
            }
        }
    }
}

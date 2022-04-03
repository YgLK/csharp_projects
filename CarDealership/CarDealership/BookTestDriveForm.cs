using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class BookTestDriveForm : Form
    {


        DataOffersHandler dataOffersHandler;

        public BookTestDriveForm()
        {
            InitializeComponent();

            DateTimePicker datePickerWithBlackoutDates = dateTimePicker1;
            dataOffersHandler = new DataOffersHandler();
            var makes = dataOffersHandler.carOffers.Keys;
            carMakeComboBox.DataSource = makes.ToList();

        }

        private void carMakeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string make = carMakeComboBox.Text;
            List<string> models = new List<string>();
            foreach (CarOffer offer in dataOffersHandler.getMakeOffers(make).ToList())
            {
                models.Add(offer.model);
            }
            carModelComboBox.DataSource = models.Distinct().ToList();
        }

        private void carModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string make = carMakeComboBox.Text;
            string model = carModelComboBox.Text;
            List<string> colors = new List<string>();
            List<string> engines = new List<string>();
            foreach (CarOffer offer in dataOffersHandler.getMakeOffers(make).ToList())
            {
                if (offer.model == model)
                {
                    colors.Add(offer.color);
                    engines.Add(offer.engine);
                }
            }
            colorComboBox.DataSource = colors.Distinct().ToList();
            engineComboBox.DataSource = engines.Distinct().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void carMakeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

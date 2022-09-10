using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class DreamCarForm : Form
    {
        DataOffersHandler dataOffersHandler;
        ReservationHandler reservationHandler;
        Dictionary<string, int> accessories;

        public DreamCarForm()
        {
            InitializeComponent();
            loadCarDealershipData();
        }

        private void loadCarDealershipData()
        {
            dataOffersHandler = new DataOffersHandler();
            reservationHandler = new ReservationHandler();
            var makes = dataOffersHandler.carOffers.Keys;
            carMakeComboBox.DataSource = makes.ToList();

            // hide text before searching
            priceLabel.Text = "";
            prodYearLabel.Text = "";

            accessories = new Dictionary<string, int>();

            accessories.Add("GPS", 100);
            accessories.Add("Parking sensors/camera", 1500);
            accessories.Add("Snow Chains", 50);
            accessories.Add("Child Seats", 200);
            accessories.Add("Car cover", 150);
            accessories.Add("Air freshener", 30);
            accessories.Add("Jumper cable", 50);

            foreach (string acc in accessories.Keys.ToList())
            {
                boxAdditionalAccessories.Items.Add(acc);
            }
            showChosenCarImage();
        }

        private void searchOffersButton_Click(object sender, EventArgs e)
        {
            showChosenCarImage();
        }


        public void showChosenCarImage()
        {
            string imageName = (colorComboBox.SelectedText + carModelComboBox.SelectedText).Replace(" ", "");
            if (imageName == String.Empty)
            {
                imageName = (colorComboBox.Text + carModelComboBox.Text).Replace(" ", "");
            }

            // if image doesnt exist
            try
            {
                // relative path to the CarImages dir where the execute file is located
                carImage.Image = Image.FromFile(@".\CarImages\" + imageName + ".png");
            }
            catch (Exception)
            {
                // relative path to the CarImages dir where the execute file is located
                carImage.Image = Image.FromFile(@".\CarImages\" + "noPicture" + ".png");
            }

            var imageSize = carImage.Image.Size;
            var fitSize = carImage.ClientSize;
            carImage.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;

            updatePriceAndYear();
        }

        public void updatePriceAndYear()
        {
            double price = 0;
            int year = 2000;

            foreach (CarOffer offer in dataOffersHandler.getMakeOffers(carMakeComboBox.Text))
            {
                if (offer.color == colorComboBox.Text && offer.model == carModelComboBox.Text && offer.engine == engineComboBox.Text)
                {
                    price = offer.price;
                    year = offer.year;
                    break;
                }
            }

            // if additional feature is picked add appropriate price of this feauture to final price and show in priceLabel.Text 
            foreach (int indexChecked in boxAdditionalAccessories.CheckedIndices)
            {
                string key = boxAdditionalAccessories.Items[indexChecked].ToString();
                // add cost of additional accessories to the final price
                price += accessories[key];
            }

            priceLabel.Text = "PRICE: " + price + "$";
            prodYearLabel.Text = "MANUFACTURING YEAR: " + year;
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

            showChosenCarImage();
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
                    engines.Add(offer.engine);
                }
            }
            engineComboBox.DataSource = engines.Distinct().ToList();
            showChosenCarImage();
        }

        private void engineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string make = carMakeComboBox.Text;
            string model = carModelComboBox.Text;
            string engine = engineComboBox.Text;
            List<string> models = new List<string>();
            List<string> colors = new List<string>();
            foreach (CarOffer offer in dataOffersHandler.getMakeOffers(make).ToList())
            {
                if (offer.model == model && offer.engine == engine)
                {
                    colors.Add(offer.color);
                }
            }
            colorComboBox.DataSource = colors.Distinct().ToList();
            updatePriceAndYear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void DeleteOffer_Click(object sender, EventArgs e)
        {
            OfferRemover remover = new OfferRemover();

            if(
                carModelComboBox.Text.Equals(String.Empty) ||
                engineComboBox.Text.Equals(String.Empty) ||
                colorComboBox.Text.Equals(String.Empty)
                )
            {
                MessageBox.Show("Pick all car offer data before deleting the offer!");
            } else
            {
                string color = colorComboBox.Text;
                string model = carModelComboBox.Text;
                string engine = engineComboBox.Text;

                // model cena kolor silnik
                string[] carOfferToRemove = new string[] { model, "," + color + "," + engine };
                string carReservationToRemove = model + "," + color + "," + engine;

                remover.RemoveOffer(carOfferToRemove);
                remover.RemoveOfferReservations(carReservationToRemove);

                MessageBox.Show("Car offer removed successfully.");
                loadCarDealershipData();
            }
        }


        private void boxAdditionalAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePriceAndYear();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showChosenCarImage();
        }
    }
}

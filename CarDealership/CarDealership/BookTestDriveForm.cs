using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class btnRemoveRes : Form
    {

        DataOffersHandler dataOffersHandler;
        ReservationHandler reservationsHandler;

        public btnRemoveRes()
        {
            InitializeComponent();

            dataOffersHandler = new DataOffersHandler();
            reservationsHandler = new ReservationHandler();

            // DateTimePicker datePickerWithBlackoutDates = dateTimePicker1;
            var makes = dataOffersHandler.carOffers.Keys;
            carMakeComboBox.DataSource = makes.ToList();
            showReservationList();
        }


        // TODO:
        // - relative path to images and reservation/offer data
        // - remove reservation functionality


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
            showReservationList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void showReservations_Click(object sender, EventArgs e)
        {
            showReservationList();
        }

        public void showReservationList()
        {
            dataGridView1.Rows.Clear();

            string date = dateTimePicker1.Text;
            string driverName = enterNameTextBox.Text;
            string make = carMakeComboBox.Text;
            string model = carModelComboBox.Text;
            string color = colorComboBox.Text;
            string engine = engineComboBox.Text;

            // get all reservations of chosen car
            var carListReservation = getReservationsCar(make, model, color, engine);

            // add reservations to the data grid view
            foreach (var offer in carListReservation)
            {
                // add reservation to list
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = offer.Item1;
                row.Cells[1].Value = offer.Item2;

                dataGridView1.Rows.Add(row);
            }
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
            showReservationList();
        }


        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            bool isAvailable = true;

            string date = dateTimePicker1.Text;
            string driverName = enterNameTextBox.Text;
            string make = carMakeComboBox.Text;
            string model = carModelComboBox.Text;
            string color = colorComboBox.Text;
            string engine = engineComboBox.Text;

            string record = date + "," + driverName + "," + make + "," + model + "," + color + "," + engine;

           if(reservationsHandler.reservations.ContainsKey(date)){
               foreach(Reservation r in reservationsHandler.reservations[date])
               {
                    if(r.date == date && r.make == make && r.model == model && r.color == color && r.engine == engine)
                    {
                        isAvailable = false;
                        MessageBox.Show("Unfortunately, this car is already reserved for this date.");
                    }
               }
           }

            if (isAvailable)
            {
                // it should append txt to cardata_test.txt
                //File.AppendAllText(@"E:\csharp_projects\advanced_programming2\CarDealership\CarDealership\Data\reservationsTestDrive.txt",
                //        record + Environment.NewLine);
                // relative path to the Data dir in the execute file is located
                File.AppendAllText(@".\Data\reservationsTestDrive.txt",
                        record + Environment.NewLine);

                if (reservationsHandler.reservations.ContainsKey(date))
                {
                    reservationsHandler.reservations[date].Add(new Reservation(date, driverName, make, model, color, engine));
                }
                else
                {
                    reservationsHandler.reservations[date] = new List<Reservation>();
                    reservationsHandler.reservations[date].Add(new Reservation(date, driverName, make, model, color, engine));
                }
                MessageBox.Show("New reservation has been added.");
            }
            showReservationList();
        }

        private List<(string, string)> getReservationsCar(string Make, string Model, string Color, string Engine)
        {
            var reservedRecord = new List<(string, string)>();

            foreach (KeyValuePair<string, List<Reservation>> entry in reservationsHandler.reservations)
            {
                foreach(Reservation r in entry.Value)
                {
                    if(r.make == Make && r.model == Model && r.color == Color && r.engine == Engine)
                    {
                        reservedRecord.Add((r.date, r.driverName));
                    }
                }
            }

            return reservedRecord;
        }

        private void engineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showReservationList();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showReservationList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chosenRowIdx = dataGridView1.SelectedCells[0].RowIndex;
            if(dataGridView1.Rows[chosenRowIdx].Cells[0].Value != null)
            {
                string chosenCellDate = dataGridView1.Rows[chosenRowIdx].Cells[0].Value.ToString();
                string chosenMake = carMakeComboBox.Text;
                string chosenModel = carModelComboBox.Text;
                string chosenColor = colorComboBox.Text;
                string chosenEngine = engineComboBox.Text;

                reservationsHandler.removeReservation(chosenCellDate, chosenMake, chosenModel, chosenColor, chosenEngine);

                MessageBox.Show("Reservation has been deleted.");
                reservationsHandler = new ReservationHandler();
                showReservationList();
            } else
            {
                MessageBox.Show("Choose correct row in the reservation list before reservation removal.");
            }
        }
    }
}

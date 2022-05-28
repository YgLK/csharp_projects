using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class ReservationHandler
    {

        // Key: Date
        // Value: driver name and Car data
        public Dictionary<string, List<Reservation>> reservations;

        public ReservationHandler()
        {
            reservations = new Dictionary<string, List<Reservation>>();
            

            string workingDirectory = Environment.CurrentDirectory;
            
            // run on the test data
            //string dataFileName = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\reservationsTestDrive.txt";


            string dataFileName = @".\Data\reservationsTestDrive.txt";
            
            using (StreamReader reader = new StreamReader(dataFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] reservation = line.Split(',');
                    // record format:
                    // date, driverName, make, model, color. engine
                    string date = reservation[0], driverName = reservation[1], make = reservation[2], model = reservation[3], color = reservation[4], engine = reservation[5];

                    if (reservations.ContainsKey(reservation[1]))
                    {
                        reservations[date].Add(new Reservation(date, driverName, make, model, color, engine));
                    } else
                    {
                        reservations[date] = new List<Reservation>();
                        reservations[date].Add(new Reservation(date, driverName, make, model, color, engine));
                    }
                }
            }
        }


        public List<Reservation> geDateReservations(string date)
        {
            // returns list of reservations of the day
            return reservations[date];
        }

        public void removeReservation(string date, string make, string model, string color, string engine)
        {
            // reservation format: 
            // 08 July 2022,Krzysztof Kowal, Volkswagen, Volkswagen Passat B6, Blue,1.4 TSI



            reservations = new Dictionary<string, List<Reservation>>();



            // run on the test data
            string dataFileName =  @".\Data\reservationsTestDrive.txt";

            string[] arrLine = File.ReadAllLines(dataFileName);
            List<string> finalLines = new List<string>();
            foreach (string line in arrLine)
            {
                string[] splittedLine = line.Split(',');
                // split:
                string resDate = splittedLine[0];
                string resMake = splittedLine[2];
                string resModel = splittedLine[3];
                string resColor = splittedLine[4];
                string resEngine = splittedLine[5];
                if (date == resDate && resMake == make && resModel == model && resColor == color && resEngine == engine)
                {
                    continue;
                }
                finalLines.Add(line);
            }

            string finalString = "";
            foreach(var line in finalLines)
            {
                finalString += line + "\n";   
            }

            File.WriteAllText(dataFileName, finalString);
        }
    }

}

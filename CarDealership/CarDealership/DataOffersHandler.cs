using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class DataOffersHandler
    {

        // Key: Make
        // Value: CarOffer
        public Dictionary<string, List<CarOffer>> carOffers;

        public DataOffersHandler()
        {
            carOffers = new Dictionary<string, List<CarOffer>>();
            

            string workingDirectory = Environment.CurrentDirectory;
            
            // run on the full data
            //string dataFileName = Directory.GetParent(workingDirectory).Parent.FullName + @"\CarData.txt";
            // run on the test data
            //string dataFileName = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\CarData_test.txt";


            string dataFileName = @".\Data\CarData_test.txt";

            using (StreamReader reader = new StreamReader(dataFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] offer = line.Split(',');
                    // line format:
                    // Year,Make,Model,Price,Color
                    string year = offer[0], make = offer[1], model = offer[2], price = offer[3], color = offer[4], engine = offer[5];

                    if (carOffers.ContainsKey(offer[1]))
                    {
                        carOffers[make].Add(new CarOffer(year, make, model, price, color, engine));
                    } else
                    {
                        carOffers[make] = new List<CarOffer>();
                        carOffers[make].Add(new CarOffer(year, make, model, price, color, engine));
                    }
                }
            }
        }


        public List<CarOffer> getMakeOffers(string make)
        {
            // returns list of car offers of the set make
            return carOffers[make];
        }
    }

}

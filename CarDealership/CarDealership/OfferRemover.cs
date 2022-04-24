using System;
using System.IO;


namespace CarDealership
{
    internal class OfferRemover
    {
        string offersFilePath;
        string reservationsFilePath;

        public OfferRemover()
        {
            offersFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Data\carData_test.txt";
            reservationsFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Data\reservationsTestDrive.txt";
        }


        public void RemoveOffer(string[] toDelete)
        {
            // toDelete contains two strings: car model and string created by merging together car engine and color

            // 1. Read the content of the file
            string[] readText = File.ReadAllLines(offersFilePath);

            // 2. Empty the file
            File.WriteAllText(offersFilePath, String.Empty);

            // 3. Fill up again, but without the deleted line
            using (StreamWriter writer = new StreamWriter(offersFilePath))
            {
                foreach (string s in readText)
                {
                    if (!(s.Contains(toDelete[0]) && s.Contains(toDelete[1])))
                    {
                        writer.WriteLine(s);
                    }
                }
            }
        }


        public void RemoveOfferReservations(string toDelete)
        {
            // toDelete has the following structure: car model,car color,car engine

            // 1. Read the content of the file
            string[] readText = File.ReadAllLines(reservationsFilePath);

            // 2. Empty the file
            File.WriteAllText(reservationsFilePath, String.Empty);

            // 3. Fill up again, but without the deleted line
            using (StreamWriter writer = new StreamWriter(reservationsFilePath))
            {
                foreach (string s in readText)
                {
                    if (!s.Contains(toDelete))
                    {
                        writer.WriteLine(s);
                    }
                }
            }
        }

        //public void RemoveOfferImage(string imagePath)
        //{
        //    // remove image associated with the removed car offer
        //    if (System.IO.File.Exists(imagePath)) { 
        //        System.IO.File.Delete(imagePath);       // car images cannot be deleted because it's used by the app at the moment of deleting
        //    };

        //}
    }
}

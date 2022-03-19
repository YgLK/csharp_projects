using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAddressInformation
{
    internal static class Program
    {
        static DataStorage dataStorage;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // init data storage
            dataStorage = new DataStorage();

            // add sample data
            dataStorage.addRecord("Jan", "Kowal", "234645234");
            dataStorage.addRecord("Grzegorz", "Klepak", "234543234");
            dataStorage.addRecord("Julia", "Kowalczyk", "524645234");
            dataStorage.addRecord("Poczekaj", "Chwilowy", "234641234");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static DataStorage getPersonalData()
        {
            return dataStorage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Reservation
    {
        //Year,Make,Model,Price,Color, Engine
        public string date;
        public string driverName;
        public string make;
        public string model;
        public string color;
        public string engine;
        public int productionYear;


        public Reservation(string Date, string DriverName, string Make, string Model, string Color, string Engine)
        {
            this.date = Date;
            this.driverName = DriverName;
            this.make = Make;
            this.model = Model;
            this.color = Color;
            this.engine = Engine;
        }
    }
}

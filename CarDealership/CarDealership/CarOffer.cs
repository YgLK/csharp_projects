using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class CarOffer
    {
        //Year,Make,Model,Price,Color, Engine
        public string make;
        public string model;
        public int year;
        public double price;
        public string color;
        public string engine;

        public CarOffer(string Year, string Make, string Model, string Price, string Color, string Engine)
        {
            this.year = Int32.Parse(Year);
            this.make = Make;
            this.model = Model;
            this.price = Double.Parse(Price);
            this.color = Color;
            this.engine = Engine;
        }
    }
}

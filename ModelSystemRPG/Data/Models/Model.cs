using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG.Data.Models
{
    public class Model
    {
        public int ModelId { get; set; }
        public string Name { get; set; }
        // properties in the JSON string
        public string PropertiesJson { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

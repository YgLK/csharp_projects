using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG.Data.Models
{
    public class ModelProperty
    {
        public int ModelPropertyId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}

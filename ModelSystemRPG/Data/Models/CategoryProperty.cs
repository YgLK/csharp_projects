using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG.Data.Models
{
    public class CategoryProperty
    {
        public int CategoryPropertyId { get; set; }
        public string Name { get; set; }
        // possible values: string, int
        public string Type { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

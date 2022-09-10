using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG
{
    public class ModelProperty
    {
        public int propertyId { get; set; }
        public string propertyName { get; set; }
        public string propertyValue { get; set; }
        public int modelId { get; set; }

        public ModelProperty(int _propertyId, string _propertyName, string _propertyValue, int _modelId)
        {
            propertyId = _propertyId;
            propertyName = _propertyName;
            propertyValue = _propertyValue;
            modelId = _modelId;
        }
    }
}

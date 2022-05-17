using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG
{
    public class ModelData
    {
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public int categoryId { get; set; }
        public string modelName { get; set; }
        public int modelId { get; set; }
        List<ModelProperty> modelProperties;

       public ModelData(string _categoryName, string _categoryDescription, int _categoryId, string _modelName, int _modelId)
        {
            categoryName = _categoryName;
            categoryDescription = _categoryDescription;
            categoryId = _categoryId;
            modelName = _modelName;
            modelId = _modelId;
            modelProperties = new List<ModelProperty>();
        }

        public List<ModelProperty> getPropertiesList()
        {
            return modelProperties;
        }

        public int MyProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG
{
    public class Sorter
    {

        public static List<ModelData> sortAlphabeticallyByCategory(Dictionary<int, ModelData> models, bool ascending)
        {
            //models: modelId, modelData
            List<ModelData> sorted = new List<ModelData>();

            // dictionary: categoryName,  List<ModelData>
            // List used here because one category can contain multiple models
            Dictionary<string, List<ModelData>> modelsByCategoryName = new Dictionary<string, List<ModelData>>();
            foreach(var model in models.Values)
            {
                string categoryName = model.categoryName;
                if (!modelsByCategoryName.ContainsKey(categoryName))
                {
                    // add new entry if not in the dictionary yet
                    modelsByCategoryName.Add(categoryName , new List<ModelData>());
                } 
                // add model to list
                modelsByCategoryName[categoryName].Add(model);
            }


            // list of names
            List<string> names = new List<string>(modelsByCategoryName.Keys);

            // sort list of names
            // ascending
            names.Sort();
            // descending
            if(ascending == false)
            {
                names.Reverse();
            }

            // retrieve models from dictionary by each key from sorted list
            foreach(string name in names)
            {
                foreach(var model in modelsByCategoryName[name])
                {
                    sorted.Add(model);
                }
            }
            return sorted;
        }

        public static List<ModelData> sortAlphabeticallyByModel(Dictionary<int, ModelData> models, bool ascending = true)
        {
            //models: modelId, modelData
            List<ModelData> sorted = new List<ModelData>();

            // dictionary: categoryName,  List<ModelData>
            // List used here because name duplicates are allowed
            Dictionary<string, List<ModelData>> modelsByModelName = new Dictionary<string, List<ModelData>>();
            foreach (var model in models.Values)
            {
                string modelName = model.modelName;
                if (!modelsByModelName.ContainsKey(modelName))
                {

                    // add new entry if not in the dictionary yet
                    modelsByModelName.Add(modelName, new List<ModelData>());
                }
                // add model to list
                modelsByModelName[modelName].Add(model);
            }


            // list of names
            List<string> names = new List<string>(modelsByModelName.Keys);

            // sort list of names
            // ascending
            names.Sort();
            // descending
            if (ascending == false)
            {
                names.Reverse();
            }

            // retrieve models from dictionary by each key from sorted list
            foreach (string name in names)
            {
                foreach (var model in modelsByModelName[name])
                {
                    sorted.Add(model);
                }
            }

            return sorted;
        }
    }
}

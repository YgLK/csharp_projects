using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSystemRPG.Data;
using System.Collections;

namespace ModelSystemRPG
{
    public class DataOperator
    {
        SystemRPGContext dbContext;
        // key: modelId, value: modelData 
        Dictionary<int, ModelData> models;

        public DataOperator()
        {
            dbContext = new SystemRPGContext();
            models = new Dictionary<int, ModelData>();
        }


        public Dictionary<int, ModelData> getModels()
        {
            // get all models
            var allModelsList = (from ep in dbContext.Categories
                              join e in dbContext.Models on ep.CategoryId equals e.CategoryId
                              select new
                              {
                                  // category name
                                  CategoryName = ep.Name,
                                  // category id
                                  CategoryId = ep.CategoryId,
                                  // category description
                                  CategoryDescription = ep.Description,
                                  // category owner id
                                  CategoryOwnerId = ep.UserId,
                                  // model name
                                  ModelName = e.Name,
                                  // model id
                                  ModelId = e.ModelId,
                              }).ToArray();



            // get all models with their properties 
            var modelData = (from ep in dbContext.Categories
                              join e in dbContext.Models on ep.CategoryId equals e.CategoryId
                              join t in dbContext.ModelProperties on e.ModelId equals t.ModelId
                              select new
                              {
                                  // category name
                                  CategoryName = ep.Name,
                                  // category id
                                  CategoryId = ep.CategoryId,
                                  // category description
                                  CategoryDescription = ep.Description,
                                  // category owner id
                                  CategoryOwnerId = ep.UserId,
                                  // model name
                                  ModelName = e.Name,
                                  // model id
                                  ModelId = e.ModelId,
                                  // property id
                                  PropertyId = t.ModelPropertyId,
                                  // property name
                                  PropName = t.Name,
                                  // property value
                                  PropValue = t.Value
                              }).ToArray();

            for(int i=0; i<modelData.Length; i++)
            {
                string categoryName = modelData[i].CategoryName;
                int categoryId = modelData[i].CategoryId;
                string categoryDescription = modelData[i].CategoryDescription;
                int categoryOwnerId = modelData[i].CategoryOwnerId;

                string modelName = modelData[i].ModelName;
                int modelId = modelData[i].ModelId;



                int propertyId = modelData[i].PropertyId;
                string propertyName = modelData[i].PropName;
                string propValue = modelData[i].PropValue;

                // craete model if doesnt occur in the dictionary
                if (!models.ContainsKey(modelId))
                {
                    ModelData model = new ModelData(categoryName, categoryDescription, categoryId, categoryOwnerId, modelName, modelId);
                    models.Add(modelId, model);
                }

                // add property to the model
                models[modelId].getPropertiesList().Add(new ModelProperty(propertyId, propertyName, propValue, modelId));
            }

            // add models without properties too
            foreach(var model in allModelsList)
            {
                if (!models.ContainsKey(model.ModelId))
                {
                    models.Add(model.ModelId, new ModelData(model.CategoryName, model.CategoryDescription, model.CategoryId, model.CategoryOwnerId, model.ModelName, model.ModelId));
                }
            }

            //}
            //  -- query to find all models with properties -- 
            //  SELECT c.Name as 'cetegory_name', m.Name as 'model_name', mp.Name as 'cecha_name', mp.Value as 'cecha_value'
            //  FROM Categories c
            //  INNER JOIN Models m ON c.CategoryId = m.CategoryId
            //  INNER JOIN ModelProperties mp ON mp.ModelId = m.ModelId;
            return models;
        }


    }
}

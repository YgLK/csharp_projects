using ModelSystemRPG.Data.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ModelSystemRPG.Data
{
    public class DBHandler
    {
        SystemRPGContext rpgDbContext;
        int lastModelId = -1;
        public DBHandler()
        {
            rpgDbContext = new SystemRPGContext();
        }

        public void addCategory(string name, int userId = 1, string description = "")
        {
            // add new category
            Category category = new Category();
            category.Name = name;
            category.UserId = userId;
            category.Description = description;
            
            rpgDbContext.Categories.Add(category);

            // save data
            rpgDbContext.SaveChanges();
        }

        public void addUser(string name, string role, string email, string password)
        {
            // add new user 
            User user = new User();
            user.Username= name;
            user.Role = role;
            user.Email = email;
            user.Password = password;
            user.Created = DateTime.Now;

            rpgDbContext.Users.Add(user);

            // save data
            rpgDbContext.SaveChanges();
        }

        public List<string> getCategoryNames()
        {
            // get all categories' names
            var categoryNames = rpgDbContext.Categories.Select(e => e.Name).ToList();
            return categoryNames;
        }

        public void deleteModel(int modelId)
        {
            var modelToDel = rpgDbContext.Models.Where(e => e.ModelId == modelId).Select(e => e).ToArray()[0];
            rpgDbContext.Remove(modelToDel);
            rpgDbContext.SaveChanges();
        }

        public void deleteModelProperty(int propertyId)
        {
            // delete model property of the given id
            var toDelProperty = rpgDbContext.ModelProperties.Where(e => e.ModelPropertyId == propertyId).Select(e => e).ToArray()[0];
            rpgDbContext.Remove(toDelProperty);
            rpgDbContext.SaveChanges();
        }

        public int getModelIdx(string categoryName, string modelName)
        {
            var model = rpgDbContext.Models.Where(e => e.Category.Name == categoryName && e.Name == modelName).ToArray()[0];
            return model.ModelId;
        }

        public void deleteAllModelProperties(int modelId)
        {
            var toDelProperties = rpgDbContext.ModelProperties.Where(e => e.ModelId == modelId).Select(e => e).ToArray();
            foreach(var property in toDelProperties)
            {
                rpgDbContext.Remove(property);
                rpgDbContext.SaveChanges();
            }
        }


        public int getCategoryIdByName(string categoryName)
        {
            // return category id of the name
            int id = rpgDbContext.Categories
                .Where(e => e.Name == categoryName)
                .Select(e => e.CategoryId).ToList()[0];
            return id;
        }

        public void addModel(string name = "NewModel", int categoryId = 1)
        {
            // add model
            Model model = new Model();
            model.Name = name;
            model.CategoryId = categoryId;

            rpgDbContext.Models.Add(model);

            // save data
            rpgDbContext.SaveChanges();

            // find id of the actually added model
            lastModelId = model.ModelId;
        }

        public void addModelProperty(int modelId, string propertyName, string propertyValue)
        {
            Models.ModelProperty modelProperty = new Models.ModelProperty();
            modelProperty.Name = propertyName;
            modelProperty.Value = propertyValue;
            modelProperty.ModelId = modelId;
            
            // add the property
            rpgDbContext.ModelProperties.Add(modelProperty);
            
            // save data
            rpgDbContext.SaveChanges();
        }

        public void addCategoryProperty(string categoryName, string propertyName, string propertyValue)
        {
            CategoryProperty categoryProperty = new CategoryProperty();
            categoryProperty.Name = propertyName;
            categoryProperty.Value = propertyValue;

            // get category id
            int categoryId = rpgDbContext.Categories.Where(e => e.Name == categoryName).Select(e => e.CategoryId).ToArray()[0];
            categoryProperty.CategoryId = categoryId;

            // add the property
            rpgDbContext.CategoryProperties.Add(categoryProperty);

            // save data
            rpgDbContext.SaveChanges();
        }


        public SystemRPGContext getDbContext()
        {
            return rpgDbContext;
        }

        public List<int> getUsersCategoriesIds(int userId)
        {
            // get all user's categories ids
            return rpgDbContext.Categories.Where(e => e.UserId == userId).Select(e => e.CategoryId).ToList();
        }

        public List<string> getUsersCategoriesNames(int userId)
        {
            // get all user's categories names
            return rpgDbContext.Categories.Where(e => e.UserId == userId).Select(e => e.Name).ToList();
        }

        public string getUserPassword(string username)
        {
            return rpgDbContext.Users.Where(e => e.Username == username).Select(e => e.Password).ToList()[0];
        }

        public User getUserByUsername(string username)
        {
            return rpgDbContext.Users.Where(e => e.Username == username).Select(e => e).ToList()[0];
        }
    }
}

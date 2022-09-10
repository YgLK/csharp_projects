using ModelSystemRPG.Data;
using ModelSystemRPG.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG
{
    public static class LoginSystem
    {
        public static LoggedUser user;
        static DBHandler dBHandler = new DBHandler();


        public static bool LogIn(string username, string password)
        {
            // check if there's username & password match in the database
            if(isPasswordCorrect(username, password))
            {
                getUserCategoriesLoaded(username);
                return true;
            } else
            {
                return false;
            }
        }

        public static void getUserCategoriesLoaded(string username)
        {
            var databaseUser = dBHandler.getUserByUsername(username);
            List<int> categoriesIdxs = dBHandler.getUsersCategoriesIds(databaseUser.UserId);
            user = new LoggedUser(databaseUser.UserId, databaseUser.Username, databaseUser.Role, databaseUser.Email, categoriesIdxs);
        }

        private static bool isPasswordCorrect(string username, string password)
        {
            string encryptedPassword = dBHandler.getUserPassword(username);
            // if user doesn't exist
            if(encryptedPassword == null)
            {
                return false;
            }
            string decryptedPassword = PasswordEncryptor.DecryptCipherTextToPlainText(encryptedPassword);
            
            if (password == decryptedPassword)
            {
                return true;
            }
            return false;
        }


        public static void LogOut()
        {
            user = null;
        }


    }
}

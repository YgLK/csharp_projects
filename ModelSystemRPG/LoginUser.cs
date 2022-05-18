using ModelSystemRPG.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSystemRPG
{
    public class LoggedUser
    {
        public int userId;
        public string userName;
        public string role;
        public string email;
        // list of categories user obtains
        List<int> categoriesIds;


        public LoggedUser(int _userId, string _userName, string _role, string _email, List<int> _categoriesIds)
        {
            userId = _userId;
            userName = _userName;
            role = _role;
            email = _email;
            categoriesIds = _categoriesIds;
        }


        public List<int> getCategoriesIds()
        {
            return categoriesIds;
        }
    }
}

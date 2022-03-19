using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAddressInformation
{
    internal class DataPerson
    {
        private string name;
        string surname;
        string phoneNumber;

        public DataPerson(string name_, string surname_, string phoneNumber_)
        {
            name = name_;
            surname = surname_;
            phoneNumber = phoneNumber_;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}

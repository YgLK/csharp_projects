using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PersonalAddressInformation
{
    internal class DataStorage
    {
        List<DataPerson> data;

        public DataStorage() => data = new List<DataPerson>();

        public void addRecord(string name_, string surname_, string phoneNumber_)
        {
            DataPerson dp = new DataPerson(name_, surname_, phoneNumber_);
            data.Add(dp);
        }    
        
        public List<DataPerson> getData()
        {
            return data;
        }
    }

}

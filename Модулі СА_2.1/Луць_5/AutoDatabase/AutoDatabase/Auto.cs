using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AutoDatabase
{
    [DataContract]
    [Serializable]
    class Auto
    {
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string AutoNumber { get; set; }
        [DataMember]
        public string AutoModel { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string HomeAdress { get; set; }
        public Auto(string name,string number,string model,double price,string adress)
        {
            LastName = name;
            AutoNumber = number;
            AutoModel = model;
            Price = price;
            HomeAdress = adress;
        }

    }
}

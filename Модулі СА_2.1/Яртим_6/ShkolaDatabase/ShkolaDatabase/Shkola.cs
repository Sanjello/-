using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShkolaDatabase
{
    [DataContract]
    [Serializable]
    public class Shkola
    {
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public double ClassNumber { get; set; }
        [DataMember]
        public double Rating1 { get; set; }
        [DataMember]
        public double Rating2 { get; set; }
        public Shkola(string name, string sex, double number, double r1, double r2)
        {
            LastName = name;
            Sex = sex;
            ClassNumber = number;
            Rating1 = r1;
            Rating2 = r2;
        }
        public Shkola() { }
    }
}
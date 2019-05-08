using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        //Constructor for person
        public Person(string _name, string _address)
        {
            name = _name;
            address = _address;
        }

        public override string ToString()
        {
            return $"Person's Name = {name}, Person's Address= {address}";
        }


















       
    }
}

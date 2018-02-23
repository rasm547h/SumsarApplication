using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsarApplication.Model
{
    public class Customer
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Customer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Customer Name: {Name}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field
        //public string FirstName;

        //property
        public int Id { get; set; }
        public string FirstName { get; set; }

        //private string _FirstName;
        //public string FirstName
        //{
        //    get { return "Mrs." + _FirstName; }
        //    set { _FirstName = value;}
        //}
        public string LastName { get; set; }
        public string City { get; set; }

    }

}

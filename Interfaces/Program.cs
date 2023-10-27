using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // InterFacesIntro();


            Console.ReadLine();

        }

    
        private static void NewMethod1()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer();
            {
                Id = 1, 
                FirstName = "Merve", 
                LastName = "Altıntaş", 
                Address = "İstanbul"
            };
            manager.Add(customer);
            manager.Add(Student);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Merve",
                LastName = "Altıntaş",
                Department = "Computer Sciens"

            };
        }
    }
    interface IPerson 
    {
     
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
 
    }
    class Customer : IPerson
    {
        public int Id { get; set;) }
        public string FirstName { get; set;) }
        public string LastName{ get; set;) }

        public string Address { get; set; }

    }
    class Student:IPerson
    {
        public int Id { get; set;) }
        public string FirstName { get; set;) }
        public string lastName { get; set;) }

        public string Deparment { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
        
    }
}



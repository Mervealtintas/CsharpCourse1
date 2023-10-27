using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        private static string City;
        private static string FirstName;
        private static string LastName;

        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.Add();
            customermanager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Merve";
            customer.LastName = "Altıntaş";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Defne", LastName = "Altıntaş"

            };

            Console.WriteLine(customer2.FirstName);

        Console.ReadLine();

        }

    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }

    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}


   






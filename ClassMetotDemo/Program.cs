using ClassMetotDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Batuhan";
            customer1.Surname = "Arslan";
            customer1.Address = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Zeynep Asena";
            customer2.Surname = "Arslan";
            customer2.Address = "Antalya";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Mert";
            customer3.Surname = "Ataoğlu";
            customer3.Address = "Samsun";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Listed(customer1);
            customerManager.Listed(customer2);

            customerManager.Delete(customer3);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri eklendi.");
        }

        public void Listed(Customer customer)
        {
            Console.WriteLine("Müşteri no : " + customer.Id);
            Console.WriteLine("Müşteri adı : " + customer.Name);
            Console.WriteLine("Müşteri soyadı : " + customer.Surname);
            Console.WriteLine("Müşteri adresi : " + customer.Address);
            Console.WriteLine("------------------------------------------");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " No'lu müşteri silindi");
        }
    }
}


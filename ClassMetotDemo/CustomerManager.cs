using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added to Customer : " + customer.CustomerName + " " + customer.CustomerSurname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted to Customer : " + customer.CustomerName + " " + customer.CustomerSurname);
        }
        public void Listed(Customer[] customers)
        {
            Console.WriteLine("--- Müşteri Listesi --- ");
            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerName + " " + item.CustomerSurname);
            }
        }
    }
}

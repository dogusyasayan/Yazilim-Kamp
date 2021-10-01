using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Dogus";
            customer1.CustomerSurname = "Yasayan";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Gizem";
            customer2.CustomerSurname = "Yildiz İzgi";

            Customer customer3 = new Customer();
            customer3.CustomerId = 1;
            customer3.CustomerName = "Mert";
            customer3.CustomerSurname = "Yildiz";

            Customer[] customers = new Customer [] { customer1,customer2,customer3};

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine(" ------------------- ");
            customerManager.Delete(customer2);
            Console.WriteLine(" ------------------- ");
            customerManager.Listed( customers);

        }
    }
}

using System;

namespace OPP2
{
    class Program
    {
        //Inheritance
        //Object Oriented Programming 
        static void Main(string[] args)
        {
            //Dogus Yasayan
            IndividualCustomer ındividual1 = new IndividualCustomer();
            ındividual1.Id = 1;
            ındividual1.CustomerNumber = "12345";
            ındividual1.Name = "Dogus";
            ındividual1.Surname = "Yasayan";
            ındividual1.TcNo = "12345678910";

            //Kodlama.io

            CoorporateCustomer coorporate = new CoorporateCustomer();
            coorporate.Id = 2;
            coorporate.CustomerNumber = "35798";   
            coorporate.CompanyName = "Kodlama.io";
            coorporate.TaxNo = "454654651";

            //Gerçek Müşteri - Tüzel Müşteri 
            //SOLID 

            Customer customer4 = new IndividualCustomer();
            Customer customer3 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
           
        }
    }
}

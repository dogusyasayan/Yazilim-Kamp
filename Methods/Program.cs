using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Comment = "Amasya Elması";
            product1.Price = 5;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Comment = "Trakya Karpuzu";
            product2.Price = 35;

            Product[] products = new Product[] { product1, product2 };

            //type -- safe -- tip güvenliği
            foreach (Product item in products)
            {
                Console.WriteLine("Meyve İsimleri : " + item.Name);
                Console.WriteLine("Meyve Fiyatı : " + item.Price);
                Console.WriteLine("Meyve Açıklaması : " + item.Comment);
                Console.WriteLine("------------------------------------" );
            }
            Console.WriteLine("---------Metotlar---------");

            //Instance - örnek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code 
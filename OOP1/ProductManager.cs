using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        //void = veriyi tutmaz , return işlemi yapılmaz
        public void Add(Product product)
        {
            product.ProductName = "Camera";
            Console.WriteLine("Added to product:"+product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Updated to product:" + product.ProductName);
        }

        public int Topla(int number1,int number2)
        {
            return number1 + number2;
        }

        public void Topla2(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }

        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}

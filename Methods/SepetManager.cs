using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart :" + product.Name );
        }

        //Aşağıda ki kullanım yanlış bi kullanımdır.Product alanına yeni bir item eklendiğin de sıkıntı yaşarız
        public void Add2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Added to cart :" + urunAdi );
        }


    }
}

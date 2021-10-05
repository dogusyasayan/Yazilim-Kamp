using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Eğer ki diğer kredi türlerinde uygulanacak hesaplama işlemi hepsinde farklı ise class yerine interface kullanıyoruz.
    interface IKrediManager
    {
        public void Hesapla();
        void BiseyYap();
      
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Krediye Basvuru Alıcaz
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Basvuran bilgilerini değerlendirme
            //design pattern = tasarım deseni
            krediManager.Hesapla();
            foreach (var logerService in loggerServices)
            {
                logerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}

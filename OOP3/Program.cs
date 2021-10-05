using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler onu implement eden classın referansını tutabilir 
            //Interfaceler birbiriniz alternatifi olan ama kod içerikleri farklı olan yapılar için kullanılır.
            //Interfaceler new lenemez.
            //IKrediManager ihtayacKrediManager2 = new IhtiyacKrediManager();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new TasitKrediManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

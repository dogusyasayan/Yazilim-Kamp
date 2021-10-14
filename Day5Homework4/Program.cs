using Day5Homework4.Abstract;
using Day5Homework4.Entities;
using Day5Homework4.Concrete;
using System;

namespace Day5Homework4
{
    class Program
    {
        //Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz,
        //Starbucks ve ve Nero Firması için çalışıyoruz.İki firma da müşterileri veri tabanına kaydetmek istiyor.
        // Starbucks müşterilerini kaydederken,mutlaka mernis doürulaması istiyor.Nero müşterileri kaydederken böyle bir şey istemiyor.Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.

        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "Doğuş",
                LastName = "Yaşayan",
                DateOfBirth = new DateTime(1997, 14, 11),
                NationalityId = "35719691652"
            }
             ); 
        }
    }
}

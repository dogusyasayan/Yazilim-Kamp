using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-) List metodunu kullan,ekrana listeyi yaz.

            List<string> TeamList = new List<string>();

            TeamList.Add("Fenerbahce");
            TeamList.Add("Galatasaray");
            TeamList.Add("Beşiktaş");
            TeamList.Add("Trabzonspor");

            foreach (var takim in TeamList)
            {
                Console.WriteLine(takim);
            }

            // 2-) Kendi Listeni olustur, (MyList) bu liste için ekleme ve silme metodu yaz
            MyList<string> teams = new MyList<string>();
            teams.Add("Dogus");
            Console.WriteLine(teams.Leghth);


        }
    }
}

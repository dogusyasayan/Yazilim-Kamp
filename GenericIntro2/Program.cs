using System;
using System.Collections.Generic;

namespace GenericIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();
            city.Add("Haarlem");
            Console.WriteLine(city.Count);
         

            MyList<string> city2 = new MyList<string>();
            city2.Add("İstanbul");
            Console.WriteLine(city2.Count);
            
        }
    }
}

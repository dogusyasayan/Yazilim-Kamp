using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack = Value Type  Heap = Referance Type
            //Array ler sabittir, 4 elemanlı tanımlandıysa 5 elemanlı yapamıyoruz.
            //string[] names = new string[] { "Dogus", "Gizem", "Eray", "Doğukan", "Mert" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);
            //names = new string[6];
            //names[5] = "Turan";
            //Console.WriteLine(names[5]);


            //List ler sabit değildir,genişletilebilir.
            List<string> names2 = new List<string> { "Dogus", "Gizem", "Eray", "Doğukan", "Mert" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[4]);
            names2.Add("Hayal");
            Console.WriteLine(names2[5]);
            Console.WriteLine(names2[0]);
            

        }
    }
}

using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string, int> myDictonary = new MyDictonary<string, int>();
            
            myDictonary.Add("Dogus", 1170);
            myDictonary.Add("Doğukan" ,970);
            foreach (int key in myDictonary.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

//4.GÜN SONU KAYIT
namespace GenericsIntro
{
    //generic class //Generic = Genel/Kapsamlı
    class MyList<T>
    {
        //Bir dizi oluşturduk.
        T[] items;
        //constuctor = Bir class new lendiğinde çalışan bloğa  constructor denir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici array
            items = new T[items.Length+1]; //new lenince yeni referans değeri alır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

            Console.WriteLine("Added to : " + item);
        }

      public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class MyList<T>
    {

        //Bir dizi oluşturduk.
        T[] items;

        //Constractor ile dizi sayısının ilk halini verdik.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1]; // new lenince yeni bir referans değeri aldı

            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        } 

        public int Leghth
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return Items}
        }




    }
}

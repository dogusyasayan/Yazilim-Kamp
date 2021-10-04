using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro2
{
    class MyList<T> //T type tan geliyor, bu classın çalışma tipi Generictir.
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

       
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        private int _count;

        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}

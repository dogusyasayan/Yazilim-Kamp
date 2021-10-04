using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<TValue, TKey>
    {
        TValue[] _values;
        TKey[] _keys;

        public MyDictonary()
        {
            _values = new TValue[0];
            _keys = new TKey[0];
        }

        public void Add(TValue value,TKey key)
        {
            TValue[]tempValueArray= _values;
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                _values[i] = tempValueArray[i];
            }
            _values[_values.Length - 1] = value;

            TKey[] tempKeyArray = _keys;
            _keys = new TKey[_keys.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _keys[i] = tempKeyArray[i];
            }
            _keys[_keys.Length - 1] = key;
        }

       

        public TValue[] Values
        {
            get { return Values; }
        }

        public TKey[] Keys
        {
            get { return Keys; }
        }
        public int Count
        {
            get { return _keys.Length; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class MyList<T>
    {
        private T[] _values = new T[4];
        private int _count;

        public void Add(T value)
        {
            if (Count == _values.Length)
            {
                T[] newValues = new T[Count * 2];

                for (int i = 0; i < Count; ++i)
                {
                    newValues[i] = _values[i];
                }

                _values = newValues;
            }

            _values[_count] = value;
            _count++;
        }

        public T this[int i]
        {
            get => _values[i];
        }

        public int Count { get => _count; }
        
    }
}

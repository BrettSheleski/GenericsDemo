using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfIntegers
{
    public class IntegerList
    {
        private int[] _values = new int[4];
        private int _count;

        public void Add(int value)
        {
            if (Count == _values.Length)
            {
                int[] newValues = new int[Count * 2];

                for (int i = 0; i < Count; ++i)
                {
                    newValues[i] = _values[i];
                }

                _values = newValues;
            }

            _values[_count] = value;
            _count++;
        }

        public int this[int i]
        {
            get => _values[i];
        }

        public int Count { get => _count; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfDoubles
{
    public class DoubleList
    {
        private double[] _values = new double[4];
        private int _count;

        public void Add(double value)
        {
            if (Count == _values.Length)
            {
                double[] newValues = new double[Count * 2];

                for (int i = 0; i < Count; ++i)
                {
                    newValues[i] = _values[i];
                }

                _values = newValues;
            }

            _values[_count] = value;
            _count++;
        }

        public double this[int i]
        {
            get => _values[i];
        }

        public int Count { get => _count; }
        
    }
}

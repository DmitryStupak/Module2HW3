using System;
using System.Collections.Generic;

namespace Module2HW3
{
    public class WeightCompare : IComparer<Vegetable>
    {
        public int Compare(Vegetable x, Vegetable y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return (int)x.Weight - (int)y.Weight;
        }
    }
}

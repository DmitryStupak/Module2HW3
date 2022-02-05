using System;
using System.Collections.Generic;

namespace Module2HW3
{
    public class CaloriesCompare : IComparer<Vegetable>
    {
        public int Compare(Vegetable x, Vegetable y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return (int)x.Calories - (int)y.Calories;
        }
    }
}

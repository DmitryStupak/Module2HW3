using System;
using System.Collections.Generic;

namespace Module2HW3
{
    public static class FindVeg
    {
        public static Vegetable[] FindByName(this Vegetable[] veg, string name)
        {
            Vegetable[] res = new Vegetable[100];
            int count = 0;
            for (int i = 0; i < veg.Length; i++)
            {
                if (veg[i].Name == name)
                {
                    res[count] = veg[i];
                    count++;
                }
            }

            Array.Resize(ref res, count);

            return res;
        }

        public static Vegetable[] FindByCalories(this Vegetable[] veg, double minCal, double maxCal)
        {
            Vegetable[] res = new Vegetable[100];
            int count = 0;
            for (int i = 0; i < veg.Length; i++)
            {
                if (veg[i].Calories <= maxCal && veg[i].Calories >= minCal)
                {
                    res[count] = veg[i];
                    count++;
                }
            }

            Array.Resize(ref res, count);

            return res;
        }
    }
}

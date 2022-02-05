using System;

namespace Module2HW3
{
    public class Salad
    {
        private Vegetable[] _salad = new Vegetable[1];
        private static int countIngr = 0;

        public Vegetable[] GetSalad()
        {
            return _salad;
        }

        public void AddIngredients(Vegetable vegetable)
        {
            if (countIngr + 1 >= _salad.Length)
            {
                Array.Resize(ref _salad, countIngr + 1);
            }

            _salad[countIngr] = vegetable;
            countIngr++;
        }

        public double GetCalories()
        {
            double res = 0;

            foreach (var item in _salad)
            {
                res += item.Calories / 100 * item.Weight;
            }

            return res;
        }
    }
}

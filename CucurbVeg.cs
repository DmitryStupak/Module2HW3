using System;

namespace Module2HW3
{
    public class CucurbVeg : Vegetable
    {
        public CucurbVeg(string name, double calories, double weight)
            : base(name, calories, weight)
        {
            Category = "Cucurbitaceae Vegetable";
        }

        public CucurbVeg(string name, double calories)
            : base(name, calories)
        {
            Category = "Cucurbitaceae Vegetable";
        }

        public virtual void Print()
        {
            Console.WriteLine($" I am Cucurbitaceae Vegetable from class {typeof(CucurbVeg).ToString()}");
        }
    }
}

using System;

namespace Module2HW3
{
    public class Cucumber : CucurbVeg
    {
        public Cucumber(double weight)
            : base("Cucumber", 16, weight)
        {
        }

        public Cucumber()
            : base("Cucumber", 16)
        {
        }

        public override void Print()
        {
            Console.WriteLine($" I am Cucumber from class {typeof(Cucumber).ToString()}");
        }
    }
}

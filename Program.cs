using System;

namespace Module2HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Salad salad = new Salad();
            salad.MakeSalad();
            Array.Sort(salad.GetSalad(), new CaloriesCompare());

            Console.WriteLine("Sort by Calories:");
            Console.WriteLine();
            foreach (var item in salad.GetSalad())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Total calories : {salad.GetCalories()}kcal");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Find ingr 10-100kcal in salad :");
            Console.WriteLine();

            foreach (var item in salad.GetSalad().FindByCalories(10, 100))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Polymorphism :");
            CucurbVeg cucurbVeg = new CucurbVeg("TestVeg", 100);
            cucurbVeg.Print();
            Cucumber cucumber = new Cucumber();
            cucumber.Print();
        }
    }
}

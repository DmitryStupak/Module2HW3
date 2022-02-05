using System;

namespace Module2HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Salad salad = new Salad();
            salad.AddIngredients((Vegetable)new RedCarrot(110));
            salad.AddIngredients((Vegetable)new Cucumber(200));
            salad.AddIngredients((Vegetable)new Potato(500));
            salad.AddIngredients((Vegetable)new ExtraVirginOil(50));
            salad.AddIngredients((Vegetable)new CherryTomato(130));
            Array.Sort(salad.GetSalad(), new CaloriesCompare());

            Console.WriteLine("Sort by Calories:");
            Console.WriteLine();
            foreach (var item in salad.GetSalad())
            {
                Console.WriteLine($"{item.Name}  {item.Calories}kcal  {item.Weight}g");
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
                Console.WriteLine($"{item.Name}  {item.Calories}kcal  {item.Weight}g");
            }
        }
    }
}

namespace Module2HW3
{
    public abstract class NightShVeg : Vegetable
    {
        public NightShVeg(string name, double calories, double weight)
            : base(name, calories, weight)
        {
            Category = "Nightshade Vegetable";
        }

        public NightShVeg(string name, double calories)
            : base(name, calories)
        {
            Category = "Nightshade Vegetable";
        }
    }
}

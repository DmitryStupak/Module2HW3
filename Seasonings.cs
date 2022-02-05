namespace Module2HW3
{
    public abstract class Seasonings : Vegetable
    {
        public Seasonings(string name, double calories, double weight)
            : base(name, calories, weight)
        {
            Category = "Seasonings";
        }

        public Seasonings(string name, double calories)
            : base(name, calories)
        {
            Category = "Seasonings";
        }
    }
}

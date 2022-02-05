namespace Module2HW3
{
    public abstract class Carrot : RootVeg
    {
        public Carrot(string name, double calories, double weight)
            : base(name, calories, weight)
        {
        }

        public Carrot(string name, double calories)
            : base(name, calories)
        {
        }
    }
}

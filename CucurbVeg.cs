namespace Module2HW3
{
    public abstract class CucurbVeg : Vegetable
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
    }
}

namespace Module2HW3
{
    public abstract class Vegetable
    {
        private double _calories;
        private double _weight;

        public Vegetable()
        {
        }

        public Vegetable(string name, double calories, double weight)
        {
            Name = name;
            Calories = calories;
            Weight = weight;
        }

        public Vegetable(string name, double calories)
        {
            Name = name;
            Calories = calories;
            Weight = 0;
        }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Calories
        {
            get => _calories;
            set => _calories = (value < 0) ? 0 : value;
        }

        public double Weight
        {
            get => _weight;
            set => _weight = (value < 0) ? 0 : value;
        }
    }
}

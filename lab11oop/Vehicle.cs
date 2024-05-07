namespace lab11oop
{
    public abstract class Vehicle
    {
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(decimal price, double speed, int year)
        {
            Price = price;
            Speed = speed;
            Year = year;
        }

        public abstract string ShowInfo();
    }
}

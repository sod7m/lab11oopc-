using System.Diagnostics;

namespace lab11oop
{
    public class Car : Vehicle
    {
        public Car(decimal price, double speed, int year) : base(price, speed, year)
        {
        }

        public override string ShowInfo()
        {
            return $"Car:\nPrice - {Price}\nSpeed - {Speed}\nYear - {Year}";
        }
    }
}

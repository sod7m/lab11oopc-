using System.Diagnostics;

namespace lab11oop
{
    public class Plain : Vehicle
    {
        public int Altitude { get; set; }
        public int Passengers { get; set; }

        public Plain(decimal price, double speed, int year, int altitude, int passengers) : base(price, speed, year)
        {
            Altitude = altitude;
            Passengers = passengers;
        }

        public override string ShowInfo()
        {
            return $"Plain:\nPrice - {Price}\nSpeed - {Speed}\nYear - {Year}\nAltitude - {Altitude}\nPassengers - {Passengers}";
        }
    }
}

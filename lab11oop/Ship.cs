using System.Diagnostics;

namespace lab11oop
{
    public class Ship : Vehicle
    {
        public string Port { get; set; }
        public int Passengers { get; set; }

        public Ship(decimal price, double speed, int year, string port, int passengers) : base(price, speed, year)
        {
            Port = port;
            Passengers = passengers;
        }

        public override string ShowInfo()
        {
            return $"Ship:\nPrice - {Price}\nSpeed - {Speed}\nYear - {Year}\nPort - {Port}\nPassengers - {Passengers}";
        }
    }
}

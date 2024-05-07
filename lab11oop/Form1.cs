using System;
using System.Windows.Forms;

namespace lab11oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // код, який виконується при завантаженні форми
        }


        private void buttonCar_Click(object sender, EventArgs e)
        {
            string[] parameters = textBoxCar.Text.Split(',');
            decimal price = decimal.Parse(parameters[0]);
            double speed = double.Parse(parameters[1]);
            int year = int.Parse(parameters[2]);

            Car car = new Car(price, speed, year);
            listBoxCar.Items.Add("Car:");
            listBoxCar.Items.Add($"Price - {car.Price}");
            listBoxCar.Items.Add($"Speed - {car.Speed}");
            listBoxCar.Items.Add($"Year - {car.Year}");
            listBoxCar.Items.Add("");
        }

        private void buttonPlain_Click(object sender, EventArgs e)
        {
            string[] parameters = textBoxPlain.Text.Split(',');
            decimal price = decimal.Parse(parameters[0]);
            double speed = double.Parse(parameters[1]);
            int year = int.Parse(parameters[2]);
            int altitude = int.Parse(parameters[3]);
            int passengers = int.Parse(parameters[4]);

            Plain plain = new Plain(price, speed, year, altitude, passengers);
            listBoxPlain.Items.Add("Plain:");
            listBoxPlain.Items.Add($"Price - {plain.Price}");
            listBoxPlain.Items.Add($"Speed - {plain.Speed}");
            listBoxPlain.Items.Add($"Year - {plain.Year}");
            listBoxPlain.Items.Add($"Altitude - {plain.Altitude}");
            listBoxPlain.Items.Add($"Passengers - {plain.Passengers}");
            listBoxPlain.Items.Add("");
        }

        private void buttonShip_Click(object sender, EventArgs e)
        {
            string[] parameters = textBoxShip.Text.Split(',');
            decimal price = decimal.Parse(parameters[0]);
            double speed = double.Parse(parameters[1]);
            int year = int.Parse(parameters[2]);
            string port = parameters[3];
            int passengers = int.Parse(parameters[4]);

            Ship ship = new Ship(price, speed, year, port, passengers);
            listBoxShip.Items.Add("Ship:");
            listBoxShip.Items.Add($"Price - {ship.Price}");
            listBoxShip.Items.Add($"Speed - {ship.Speed}");
            listBoxShip.Items.Add($"Year - {ship.Year}");
            listBoxShip.Items.Add($"Port - {ship.Port}");
            listBoxShip.Items.Add($"Passengers - {ship.Passengers}");
            listBoxShip.Items.Add("");
        }
    }
}

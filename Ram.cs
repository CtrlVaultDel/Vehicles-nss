using System;
using System.Globalization;

namespace Vehicles
{
    class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }


        public void RefuelTank()
        {
            CurrentTankPercentage = 1.00;
            Console.WriteLine("The Ram truck's gas tank has been refueled!");
        }
        public void DisplayGasTank()
        {
            Console.WriteLine($"{this.GetType().Name} Gas Level: {CurrentTankPercentage.ToString("P", CultureInfo.InvariantCulture)}");

        }
        public override string Drive()
        {
            return "Vroum Vroum!";
        }
        public override string Turn()
        {
            Random rnd = new Random();
            int turnNumber = rnd.Next(0, 2);
            string turnDirection;
            if (turnNumber == 0)
            {
                turnDirection = "left";
            }
            else
            {
                turnDirection = "right";
            }
            return $"The {MainColor} Ram Truck turns {turnDirection}.";
        }

        public override string Stop()
        {
            return $"The {MainColor} Ram Truck comes to a complete stop after making a gnarly jump.";
        }
        public Ram()
        {
            CurrentTankPercentage = RandomNumber();
        }
    }
}
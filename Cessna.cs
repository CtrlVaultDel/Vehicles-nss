using System;
using System.Globalization;

namespace Vehicles
{
    class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 1.00;
            Console.WriteLine("The Cessna's gas tank has been refueled!");
        }
        public void DisplayGasTank()
        {
            Console.WriteLine($"{this.GetType().Name} Gas Level: {CurrentTankPercentage.ToString("P", CultureInfo.InvariantCulture)}");
        }
        public override string Drive()
        {
            return "Neeerrrrrrrrrrrwuuuuuuuuuu!";
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
            return $"The {MainColor} Cessna turns {turnDirection}.";
        }

        public override string Stop()
        {
            return $"After rolling down the runway, the {MainColor} Cessna comes to a complete stop.";
        }

        public Cessna()
        {
            CurrentTankPercentage = RandomNumber();
        }
    }
}
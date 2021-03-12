using System;

namespace Vehicles
{
    class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Gas tank has been refueled!");
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
    }
}
using System;

namespace Vehicles
{
    class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Gas tank has been refueled!");
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
    }
}
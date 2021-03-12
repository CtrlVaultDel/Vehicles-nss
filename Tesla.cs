using System;

namespace Vehicles
{
    class Tesla : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery has been recharged!");
        }
        public override string Drive()
        {
            return "Ssssssssssssssss!";
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
            return $"The {MainColor} Tesla turns {turnDirection}.";
        }

        public override string Stop()
        {
            return $"The {MainColor} Tesla comes to a complete stop very quietly.";
        }
    }
}
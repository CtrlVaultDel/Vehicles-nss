using System;

namespace Vehicles
{
    class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery has been recharged!");
        }
        public override string Drive()
        {
            return "WrrrrrrrrrWrrrrrrrrr";
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
            return $"The {MainColor} Zero turns {turnDirection}";
        }

        public override string Stop()
        {
            return $"The {MainColor} Zero comes to a complete stop after popping a wheelie.";
        }
    }
}
using System;
using System.Globalization;

namespace Vehicles
{
    class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; } = 0.88;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 1.00;
            Console.WriteLine("The Zero's battery has been recharged!");
        }
        public void DisplayCharge()
        {
            Console.WriteLine($"{this.GetType().Name} Charge: {CurrentChargePercentage.ToString("P", CultureInfo.InvariantCulture)}");
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
        public Zero()
        {
            CurrentChargePercentage = RandomNumber();
        }
    }
}
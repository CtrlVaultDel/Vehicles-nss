using System;
using System.Globalization;

namespace Vehicles
{
    class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; } = 0.57;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 1.00;
            Console.WriteLine("The Tesla's battery has been recharged!");
        }

        public void DisplayCharge()
        {
            Console.WriteLine($"{this.GetType().Name} Charge: {CurrentChargePercentage.ToString("P", CultureInfo.InvariantCulture)}");
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
        public Tesla()
        {
            CurrentChargePercentage = RandomNumber();
        }
    }
}
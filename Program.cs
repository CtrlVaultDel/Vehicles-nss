using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");

            // Show the current charge of the electric vehicles
            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.DisplayCharge();
            }

            // Recharge all electric vehicles
            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            // Show the current charges again (Should be 100% now)
            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.DisplayCharge();
            }

            Console.WriteLine();
            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");

            // Show the current gas level of the gas vehicles
            foreach (IGasVehicle gv in gasVehicles)
            {
                gv.DisplayGasTank();
            }

            // Refuel all gas vehicles
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            // Show the current gas levels again (Should be 100%)
            foreach (IGasVehicle gv in gasVehicles)
            {
                gv.DisplayGasTank();
            }
        }
    }
}

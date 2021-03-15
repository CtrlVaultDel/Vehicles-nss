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

            Console.WriteLine("=====Electric Vehicles=====");

            // Iterates through all electric vehicles
            // Show each vehicle's initial charge
            // Recharge the vehicle
            // Show the new charge
            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.DisplayCharge();
                ev.ChargeBattery();
                ev.DisplayCharge();
                Console.WriteLine();
            }
            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
              };

            Console.WriteLine("=====Gas Vehicles=====");

            // Iterates through all gas vehicles
            // Show each vehicle's initial gas tank amount
            // Refuel the vehicle
            // Show the new gas tank
            foreach (IGasVehicle gv in gasVehicles)
            {
                gv.DisplayGasTank();
                gv.RefuelTank();
                gv.DisplayGasTank();
                Console.WriteLine();
            }
        }
    }
}
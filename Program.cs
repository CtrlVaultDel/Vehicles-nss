using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna cessna = new Cessna
            {
                MainColor = "Black",
                MaxCapacity = 4
            };
            Ram ram = new Ram
            {
                MainColor = "Gray",
                MaxCapacity = 4
            };
            Tesla tesla = new Tesla
            {
                MainColor = "Blue",
                MaxCapacity = 4
            };
            Zero zero = new Zero
            {
                MainColor = "Green",
                MaxCapacity = 1
            };
            Console.WriteLine("Check out this garage!");

            cessna.TestDrive();
            ram.TestDrive();
            tesla.TestDrive();
            zero.TestDrive();
        }
    }
}

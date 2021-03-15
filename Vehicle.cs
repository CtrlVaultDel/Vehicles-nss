using System;

namespace Vehicles
{
    class Vehicle
    {
        public string MainColor { get; set; }
        public int MaxCapacity { get; set; }

        // RandomNumber is used to generate a random number between 0 and 0.99.
        // This value is
        public double RandomNumber()
        {
            Random rnd = new Random();
            double startingPercentage = rnd.NextDouble();
            return startingPercentage;

        }
        public virtual string Drive()
        {
            return "Vrooooooom!";
        }

        public virtual string Turn()
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
            return $"The vehicle turns {turnDirection}.";
        }

        public virtual string Stop()
        {
            return $"The {MainColor} vehicle comes to a complete stop.";
        }
        public void TestDrive()
        {
            Console.WriteLine(Drive());
            Console.WriteLine(Turn());
            Console.WriteLine(Stop());
            Console.WriteLine();
        }
    }
}
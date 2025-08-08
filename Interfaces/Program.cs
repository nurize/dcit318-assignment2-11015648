using System;

namespace Interface
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interface Demo ===");

            IMovable myCar = new Car();
            myCar.Move();  

            IMovable myBicycle = new Bicycle();
            myBicycle.Move();  

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
// End of file: dcit318-assignment2-11015648/Inheritance/Program.cs
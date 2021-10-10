using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Color();
            Console.WriteLine(newCar.brand);
            Console.WriteLine(newCar.modal);
        }
    }
}

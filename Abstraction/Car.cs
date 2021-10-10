using System;
namespace Abstraction
{
    abstract class Car
    {
        public abstract void Color();
        public void Carcolor()
        {
            Console.WriteLine("Red Color");
        }
    }
    class Hyundai : Car
    {
        public override void Color()
        {
            Console.WriteLine("The Car is i20");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Hyundai hyundai = new Hyundai();
            hyundai.Color();
            hyundai.Carcolor();
        }
    }
}

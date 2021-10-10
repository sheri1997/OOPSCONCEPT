using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car myMaruti = new Maruti();
            Car myHyundai = new Hyundai();
            myCar.carColor();
            myMaruti.carColor();
            myHyundai.carColor();
        }
    }
}

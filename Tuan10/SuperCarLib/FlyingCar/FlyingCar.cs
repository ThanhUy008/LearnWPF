using SuperCarLib;
using System;

namespace FlyingCar
{
    public class FlyingCar : Car
    {
        public string Name { get => "Flying car"; }

        public void Depart()
        {
            Console.WriteLine("Checking gasoline level");
            Console.WriteLine("Checking wind direction");
            Console.WriteLine("Flying car is starting");
        }

        public Car Clone()
        {
            return new FlyingCar();
        }
    }
}

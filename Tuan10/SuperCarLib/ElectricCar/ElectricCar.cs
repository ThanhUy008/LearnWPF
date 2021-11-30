using SuperCarLib;
using System;

namespace ElectricCar
{
    public class ElectricCar : Car
    {
        public string Name { get => "Electric"; }

        public void Depart()
        {
            Console.WriteLine("Checking battery level");
            Console.WriteLine("ElectricCar is starting");
        }

        public Car Clone()
        {
            return new ElectricCar();
        }
    }
}

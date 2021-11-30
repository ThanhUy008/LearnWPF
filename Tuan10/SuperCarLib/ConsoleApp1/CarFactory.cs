using SuperCarLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CarFactory
    {
        public static CarFactory instance;
        List<Car> _prototypes; // Prototype

        public static CarFactory getInstance()
        {
            if (instance == null)
            {
                instance = new CarFactory();
            }
            return instance;
        }
        public CarFactory()
        {
            _prototypes = new List<Car>();

            // Nạp danh sách các tập tin dll
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = Path.GetDirectoryName(exePath);
            Console.WriteLine(folder);
            var fis = new DirectoryInfo(folder).GetFiles("*.dll");

            foreach (var f in fis) // Lần lượt duyệt qua các file dll
            {
                var assembly = Assembly.LoadFile(f.FullName);
                var types = assembly.GetTypes();

                foreach (var t in types)
                {
                    if (t.IsClass && typeof(Car).IsAssignableFrom(t))
                    {
                        Car c = (Car)Activator.CreateInstance(t);
                        _prototypes.Add(c);
                    }
                }
            }
        }

        public Car Create(int choice)
        {
            Car result = _prototypes[choice - 1].Clone();

            return result;
        }

        public void DisplayMenu()
        {
            for (int i = 0; i < _prototypes.Count; i++)
            {
                Car car = _prototypes[i];
                Console.WriteLine($"{i + 1}. {car.Name}");
            }
        }
    }
}

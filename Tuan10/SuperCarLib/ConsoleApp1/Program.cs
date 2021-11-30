using SuperCarLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
       


        static void Main(string[] args)
        {
            // Hiển thị menu
            CarFactory factory = CarFactory.getInstance();
            Console.WriteLine("Which car do you want to create?");
            factory.DisplayMenu();

            int choice = int.Parse(Console.ReadLine());

            Car c1 = factory.Create(choice);
            c1.Depart();

            Console.ReadLine();
        }
    }
}

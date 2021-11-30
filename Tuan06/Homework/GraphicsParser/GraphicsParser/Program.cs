using System;
using System.Collections.Generic;
using System.IO;

namespace GraphicsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            var factory = new ShapeFactory();
            string filename = "mypaint.txt";
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string buffer = reader.ReadLine();
                    int firstSpaceIndex = buffer.IndexOf(" ");
                    string name = buffer.Substring(0, firstSpaceIndex);
                    shapes.Add(factory.CreateShape(name, buffer));
                }
            }

          

            foreach (var shape in shapes)
            {
                Console.WriteLine(factory.ReadShape(shape));
            }
            Console.ReadLine();
        }
    }
}

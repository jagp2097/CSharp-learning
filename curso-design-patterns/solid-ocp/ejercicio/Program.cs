using System;
using System.Collections.Generic;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            List<object> shapes = new List<object>{
                new Rectangle{ Width = 12.21, Height = 3.31 },
                new Circle{ Radius = 3.2 },
                new Circle{ Radius = 2 }
            };

            Console.WriteLine(areaCalculator.Area(shapes));
        }
    }
}

using System;
using System.Collections.Generic;

namespace solucion
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            
            List<IShape> shapes = new List<IShape>{
                new Circle{ Radius = 2 },
                new Rectangle{ Width = 2, Height = 3 },
                new Circle{ Radius = 3 }
            };
            
            Console.WriteLine(areaCalculator.Area(shapes));
        }
    }
}

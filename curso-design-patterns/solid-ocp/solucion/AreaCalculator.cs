using System;
using System.Collections.Generic;

namespace solucion
{
    public class AreaCalculator
    {
        public string Area(List<IShape> shapes)
        {
            string area = "";

            foreach (IShape shape in shapes)
            {
                area += shape.Area();
                area += Environment.NewLine;
            }
            return area;
        }
    }
}
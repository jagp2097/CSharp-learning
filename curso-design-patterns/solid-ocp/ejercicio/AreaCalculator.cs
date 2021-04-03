using System;
using System.Collections.Generic;

namespace ejercicio
{
    public class AreaCalculator
    {
        public string Area(List<object> shapes)
        {
            string area = "";

            foreach (object shape in shapes )
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle) shape;
                    area += $"Rectangulo: {rectangle.Width * rectangle.Height}";
                }
                else
                {
                    Circle circle = (Circle) shape;
                    area += $"Circulo: {circle.Radius * circle.Radius * Math.PI}";
                }
            area += Environment.NewLine;
            }
            return area;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_Formas
{
    class Circle : Shape
    {
        public float _radius;

        public Circle(float radius, Color color) : base (color)
        {
            _radius = radius;
        }

        public override float Area()
        {
            double areaDouble = Math.PI * Math.Pow(_radius, 2);
            return (float)areaDouble;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_Formas
{
    abstract class Shape
    {
        public Color _color { get; set; }
        public Shape(Color color)
        {
            _color = color;
        }
        public abstract float Area();
    }
}

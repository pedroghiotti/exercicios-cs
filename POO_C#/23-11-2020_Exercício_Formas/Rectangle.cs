using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020_Exercício_Formas
{
    class Rectangle : Shape
    {
        public float _height, _width;

        public Rectangle(float height, float width, Color color) : base(color)
        {
            _width = width;
            _height = height;
        }

        public override float Area()
        {
            return _width * _height;
        }
    }
}

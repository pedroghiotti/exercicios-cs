using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_1_07_09_2020
{
    class Rectangle
    {
        private double _width, _height;
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double Area()
        {
            return (_width * _height);
        }
        public double Perimeter()
        {
            return 2 * (_width + _height);
        }
        public double Diagonal()
        {
            return Math.Sqrt( Math.Pow(_width, 2) + Math.Pow(_height, 2));
        }
        public override string ToString()
        {
            return new string
                (
                "\nLargura - " + _width        +
                "\nAltura - " + _height        +
                "\nÁrea - " + Area()           +
                "\nPerímetro - " + Perimeter() +
                "\nDiagonal - " + Diagonal()   
                );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício1_Programação_Orientada_a_Objetos
{
    class Triangle
    {
        internal float a, b, c, p, area;
        internal void CalculateArea()
        {
            p = (a + b + c) / 2;
            area = Convert.ToSingle(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
    }
}

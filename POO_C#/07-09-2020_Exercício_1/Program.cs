using System;
using System.Runtime.InteropServices;

namespace Exercício_1_07_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Largura do retângulo - ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Altura do retângulo - ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine(rectangle);
        }
    }
}

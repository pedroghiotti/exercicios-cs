using System;

namespace Exercício1_Programação_Orientada_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara e instancia os objetos.
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            // Recebe os valores e calcula as áreas.
            Console.WriteLine("Digite os lados de dois triângulos.");
            x.a = float.Parse(Console.ReadLine());
            x.b = float.Parse(Console.ReadLine());
            x.c = float.Parse(Console.ReadLine());
            x.CalculateArea();
            
            y.a = float.Parse(Console.ReadLine());
            y.b = float.Parse(Console.ReadLine());
            y.c = float.Parse(Console.ReadLine());
            y.CalculateArea();

            // Decide qual área é a maior e dá os resultados ao usuário.
            Console.WriteLine("Área do triângulo 1 = " + x.area + "\nÁrea do triângulo 2 = " + y.area);
            if (x.area > y.area)
            {
                Console.WriteLine("A área do triângulo 1 é maior.");
            }
            else 
            {
                Console.WriteLine("A área do triângulo 2 é maior.");
            }
        }
    }
}

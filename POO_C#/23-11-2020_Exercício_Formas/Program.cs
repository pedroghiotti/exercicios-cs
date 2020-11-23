using System;
using System.Collections.Generic;

namespace _23_11_2020_Exercício_Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // Número de formas a serem definidas
            List<Shape> shapes = new List<Shape>(); // Guarda as Instâncias da classe Shape e de suas subclasses

            Console.Write("Número de formas que deseja calcular a área: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDefina as formas desejadas:\n");
            for (int i = 0; i < n; i++) // Gera uma forma a quantidade de vezes definida pelo usuário
            {
                Console.Write("\nCírculo ou retângulo? (C / R) ");
                string choice = Console.ReadLine().ToLower(); // Guarda a escolha do usuário em uma string e converte pra letras minúsculas para evitar erros

                Console.Write("Cor (Preto/Azul/Vermelho): "); // Pede que o usuário selecione a cor
                string colChoice = Console.ReadLine().ToLower();
                Color color; // Instancia variável da classe "Color". Seu valor será atribuído abaixo
                switch (colChoice)
                {
                    case "preto": color = Color.black; break;
                    case "vermelho": color = Color.red; break;
                    case "azul": color = Color.blue; break;
                    default: color = Color.black; break;
                }

                switch (choice)
                {
                    case "c": // Caso usuário selecione círculo pede o raio e gera a instância da classe "Circle"

                        Console.Write("Raio: ");
                        float radius = float.Parse(Console.ReadLine());

                        shapes.Add(new Circle(radius, color)); // Adiciona à lista dos formatos gerados

                        break;
                    case "r": // Caso usuário selecione etângulo pede altura e largura e gera a instância da classe "Rectangle"

                        Console.Write("Largura: ");
                        float width = float.Parse(Console.ReadLine());

                        Console.Write("Altura: ");
                        float height = float.Parse(Console.ReadLine());

                        shapes.Add(new Rectangle(height, width, color)); // Adiciona à lista dos formatos gerados

                    break;
                }
            }

            Console.WriteLine("\nÁrea das formas:");
            foreach (var element in shapes)
            {
                switch (element._color) // Troca a cor do texto dependendo da cor do formato (só pra usar essa cor em algum lugar...)
                {
                    case Color.black:
                        Console.BackgroundColor = ConsoleColor.White; // No caso do preto troca também a cor do fundo. Se não o texto desaparece no fundo preto...
                        Console.ForegroundColor = ConsoleColor.Black;
                    break;
                    case Color.red: Console.ForegroundColor = ConsoleColor.Red; break;
                    case Color.blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                    default: Console.ForegroundColor = ConsoleColor.White; break;
                }
                Console.WriteLine(element.Area()); // Chama método das classes que calcula a área
                Console.BackgroundColor = ConsoleColor.Black; // Reseta cores do Console
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Escreva os nomes e salários de duas pessoas\n");
            Console.Write("Nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("\nSalário da primeira pessoa: ");
            p1.salário = float.Parse(Console.ReadLine());

            Console.Write("\n\nNome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("\nSalário da segunda pessoa: ");
            p2.salário = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\nA média dos salários de " + p1.nome + " e " + p2.nome + " é " + (p1.salário + p2.salário) / 2+".");
        }
    }
}

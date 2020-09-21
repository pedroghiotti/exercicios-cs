using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Escreva os nomes e idades de duas pessoas.\n");
            Console.Write("Nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("\nIdade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.Write("\n\nNome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("\nIdade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("\n\n" + p1.nome + " é mais velho que " + p2.nome + ".");
            }
            else 
            {
                Console.WriteLine("\n\n" + p2.nome + " é mais velho que " + p1.nome + ".");
            }
        }
    }
}

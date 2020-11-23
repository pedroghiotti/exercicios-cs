using System;
using System.Collections.Generic;

namespace _23_11_2020_Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContaGenerica> contas = new List<ContaGenerica>();

            contas.Add(new ContaPoupanca(10, 1, "Júnior Júnior", 500));
            contas.Add(new ContaPoupanca(10, 2, "João de Alguma Coisa", 1000));
            contas.Add(new ContaJur(1000, 3, "Fulano da Silva", 1500));
            contas.Add(new ContaJur(1000, 4, "Donald Mc Donald", 2000));

            double soma = 0;
            foreach (var conta in contas)
            {
                soma += conta._saldo;
            }
            Console.WriteLine("Total do saldo de todas as contas: " + soma);

            foreach (var conta in contas)
            {
                conta.Saque(10);
            }

            Console.WriteLine("Atualização do saldo das contas:\n");
            foreach (var conta in contas)
            {
                Console.WriteLine(conta._numero + " (" + conta._titular + ") - " + conta._saldo);
            }
        }
    }
}

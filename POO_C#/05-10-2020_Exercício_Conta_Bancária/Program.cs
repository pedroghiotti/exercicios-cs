using System;
using System.Runtime.InteropServices;

namespace _05_10_2020_Exercício_Conta_Bancária
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Registrar();
            Console.WriteLine(conta);

            int select = 0; // Variável que guarda o Input do usuário.
            while (select != 4) // Loop que permite o usuário escolher o que deseja fazer no programa. Funciona como uma espécie de menu.
            {
                Console.WriteLine("\nSelecione a opção que deseja:\n\n1: Depósito.\n2: Saque.\n3: Alterar nome titular.\n4: Sair.");
                int.TryParse(Console.ReadLine(), out int result); // Retorna 0 caso o Input não seja do tipo requisitado (int).
                select = result;
                switch (select) // Chama o método equivalente à opção escolhida pelo usuário.
                {
                    case 1:
                        conta.Deposito();
                        Console.WriteLine(conta);
                    break;
                    case 2:
                        conta.Saque();
                        Console.WriteLine(conta);
                    break;
                    case 3:
                        conta.AlterarNome();
                        Console.WriteLine(conta);
                    break;
                    default:
                        Console.Clear();
                    break;
                }
            }
        }
    }
}

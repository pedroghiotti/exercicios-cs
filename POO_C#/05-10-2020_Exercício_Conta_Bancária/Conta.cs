using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _05_10_2020_Exercício_Conta_Bancária
{
    class Conta
    {
        int accountNumber;
        string name;
        double balance;

        public override string ToString()
        {
            Console.Clear();
            return "Informações atualizadas da conta:\n\nNúmero da conta: " + accountNumber + "\nNome do titular: " + name + "\nBalanço: " + balance;
        }
        public void Registrar()
        {
            Console.WriteLine("Insira seus dados para registrar a conta.");
            Console.Write("Nome do titular: ");
            name = Console.ReadLine();
            Console.Write("Número da conta: ");
            accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Gostaria de fazer um depósito inicial? [ S / N ]");
            string choice = Console.ReadLine().ToLower();
            if (choice == "s")
            {
                Deposito();
            }
        }
        public void AlterarNome()
        {
            Console.Write("Novo nome a ser usado: ");
            name = Console.ReadLine();
        }
        public void Deposito()
        {
            Console.Write("Valor do depósito: ");
            balance += double.Parse(Console.ReadLine());
        }
        public void Saque()
        {
            Console.Write("Valor do saque: ");
            balance -= 5;
            balance -= double.Parse(Console.ReadLine());
        }
    }
}

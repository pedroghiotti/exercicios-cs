using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _26_10_2020_Exercício_Salários
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Funcionários a adicionar: ");
            int n = int.Parse(Console.ReadLine()); // Número de funcionários dado pelo usuário.

            List<Employee> employees = new List<Employee>(); // Declara a lista 'employees'.

            for (int i = 0; i < n; i++) // Adiciona um funcionário novo a quantidade de vezes determinada pelo usuário (guardada em 'n').
            {
                Console.Write("\nNome: ");
                string tmpName = Console.ReadLine(); // Variável temporária que guarda o nome do funcionário.

                Console.Write("ID: ");
                int tmpID = int.Parse(Console.ReadLine()); // Variável temporária que guarda o ID do funcionário.

                while (employees.FindAll(x => x._id == tmpID).Count > 0) // Através do método 'List.FindAll()', forma uma lista contendo todos os funcionários com o ID dado pelo usuário. Caso haja outro com o ID escolhido, pede para escolher um diferente. 
                {
                    Console.Write("ID já existente. Introduza outro ID: ");
                    tmpID = int.Parse(Console.ReadLine());
                }

                Console.Write("Salário: ");
                double tmpSalary = double.Parse(Console.ReadLine()); // Variável temporária que guarda o salário do funcionário.

                var tmpEmployee = new Employee(tmpName, tmpID, tmpSalary); // Variável temporária que guarda o funcionário gerado.
                employees.Add(tmpEmployee); // Adiciona o funcionário gerado à lista.
            }

            Console.Clear(); // Limpa a tela do console.
            foreach(var element in employees) // Escreve os dados de cada funcionário.
            {
                Console.WriteLine(element);
            }

            Console.Write("\nID do funcionário o qual deseja aumentar o salário: ");
            int raiseID = int.Parse(Console.ReadLine()); // Variável guarda o ID do funcionário que receberá aumento.
            if (employees.FindAll(x => x._id == raiseID).Count < 1) // Se não houver funcionário correspondente ao ID dado aborta operação.
            {
                Console.Clear();

                Console.Write("ID não corresponde a nenhum funcionário.");
            }
            else // Se houver, pede o valor do aumento, acha o funcionário com ID correspondente e chama o método responsável pelo aumento.
            {
                Console.Write("\nValor do aumento em porcentagem: ");
                float raisePercent = int.Parse(Console.ReadLine());
                employees.Find(x => x._id == raiseID).Raise(raisePercent);

                Console.Clear();
            }

            foreach(var element in employees) // Escreve os dados de cada funcionário. 
            {
                Console.WriteLine(element);
            }
        }
    }
}
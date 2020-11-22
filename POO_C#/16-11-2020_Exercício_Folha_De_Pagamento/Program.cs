using System;
using System.Collections.Generic;

namespace _16_11_2020_Exercício_Folha_De_Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); // Guarda as instâncias da classe "Employee"
            int n; // Número de empregados a registrar dado pelo usuário

            Console.Write("Número de funcionários: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // Loop para criar determinado número de funcionários
            {
                Console.WriteLine("\nFuncionário terceirizado? S/N");
                string choice = Console.ReadLine().ToLower(); // Guarda a escolha

                Console.Write("\nNome: ");
                string name = Console.ReadLine(); // Guarda nome temporáriamente

                Console.Write("Horas trabalhadas: ");
                int hoursWorked = int.Parse(Console.ReadLine()); // Guarda horas trabalhadas temporáriamente

                Console.Write("Salário por hora: ");
                double hourlyWage = double.Parse(Console.ReadLine()); // Guarda salário por hora temporáriamente

                if (choice == "s") // Se for terceirizado pede que o usuário dê o bônus
                {
                    Console.Write("Bônus: ");
                    double extra = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee(extra, name, hoursWorked, hourlyWage)); // Cria funcionário terceirizado
                }
                else
                {
                    employees.Add(new Employee(name, hoursWorked, hourlyWage)); // Cria funcionário genérico
                }
            }

            Console.Clear(); // Limpa a tela do console
            foreach (var element in employees) // Itera por cada um dos elementos da lista e escreve os dados
            {
                Console.WriteLine(element.Info());
            }
        }
    }
}

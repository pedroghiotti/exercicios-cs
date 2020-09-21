using System;

namespace Exercício_2_17_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do empregado - ");
            string name = Console.ReadLine();

            Console.Write("Salário bruto - ");
            double grossSalary = double.Parse(Console.ReadLine());

            Console.Write("Imposto - ");
            double tax = double.Parse(Console.ReadLine());

            Employee employee = new Employee(name, grossSalary, tax);

            Console.WriteLine(employee);

            Console.Write("\nPorcentagem do aumento - ");
            employee.raiseByPercent(double.Parse(Console.ReadLine()));

            Console.WriteLine(employee);
        }
    }
}

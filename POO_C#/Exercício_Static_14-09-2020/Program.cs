using System;

namespace Exercício_Static_14_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar atualmente?");
            double conversionRate = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantos dólares irá comprar?");
            double valueInDollars = double.Parse(Console.ReadLine());

            Console.WriteLine("\nO valor a ser pago em Reais é de " + Converter.ConvertDollarToReal(valueInDollars, conversionRate));
        }
    }
}

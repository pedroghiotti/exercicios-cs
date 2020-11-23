using System;
using System.Collections.Generic;

namespace _23_11_2020_Exercício_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // Número de produtos a registrar
            List<Product> products = new List<Product>(); // Lista armazena produtos gerados

            Console.Write("Número de produtos a registrar: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nProduto comum, usado ou importado? Responda com C, U ou I: ");
                string choice = Console.ReadLine().ToLower(); // Guarda a resposta do usuário e converte para letra minúscula para evitar erro

                Console.Write("Nome: ");
                string name = Console.ReadLine(); // Guarda nome do produto sendo registrado atualmente

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine()); // guarda preço do produto sendo registrado atualmente

                switch (choice)
                {
                    case "c": // Caso seja produto comum adiciona à lista sem pedir informação adicional
                        products.Add(new Product(name, price));
                        break;

                    case "u": // Caso seja produto usado pede a data e então adiciona à lista
                        Console.Write("Data de fabricação (dia/mês/ano): ");
                        int[] tmpDateArray = new int[3]; // Array guarda dia, mês e ano em forma de int
                        int tmpDateArrayIndex = 0; // Índice usado no loop abaixo
                        foreach (var element in Console.ReadLine().Split("/")) // Recebe o input no formato dia/mês/ano, separa em três strings, converte essas pra int e adiciona ao array acima
                        {
                            tmpDateArray[tmpDateArrayIndex] = int.Parse(element);
                            tmpDateArrayIndex++;
                        }
                        DateTime tmpManufacturingDate = new DateTime(tmpDateArray[2], tmpDateArray[1], tmpDateArray[0]); // Variável temporária do tipo DateTime com a data dada pelo usuário
                        products.Add(new UsedProduct(name, price, tmpManufacturingDate));
                        break;

                    case "i": // Case seja produto importado pede a taxa então adiciona à lista
                        Console.Write("Taxa: ");
                        double tax = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, tax));
                        break;
                }
            }
            Console.Clear(); // Limpa a tela do console
            foreach (var element in products) // Imprime cada produto na ordem na qual foi registrado
            {
                Console.WriteLine("\n" + element.PriceTag());
            }
        }
    }
}

using System;

namespace Exercício_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza as informações pedidas:");
            
            Console.Write("\nNome do produto: ");
            string name = Console.ReadLine();

            Console.Write("\nPreço: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("\nQuantidade em estoque: ");
            int amountInStock = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, amountInStock); // Cria uma instância da classe 'Produto' com os parâmetros dados pelo usuário.

            Console.WriteLine("\nInformações atualizadas do produto: " + product); // Escreve as informações do produto usando o método 'override ToString()'.

            Console.Write("\nQuantia a ser adicionada ao estoque - ");
            product.AddToStock(int.Parse( Console.ReadLine() ));

            Console.Write("\nQuantia a ser removida do estoque - ");
            product.RemoveFromStock(int.Parse( Console.ReadLine() ));

            Console.WriteLine("\nInformações atualizadas do produto: " + product);
        }
    }
}

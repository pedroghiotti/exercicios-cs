using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Exercício_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Stocked_Item item = new Stocked_Item();
            
            Console.Write("\nProduto - ");
            item.product = Console.ReadLine();
            
            Console.Write("\nPreço - ");
            item.price = double.Parse(Console.ReadLine());

            Console.Write("\nQuantidade em estoque - ");
            item.amountInStock = int.Parse(Console.ReadLine());

            Console.WriteLine(item);

            Console.Write("\nQuantidade a ser adicionada ao estoque - ");
            item.AddToStock(int.Parse(Console.ReadLine()));

            Console.Write("\nQuantidade a ser removida do estoque - ");
            item.SubtractFromStock(int.Parse(Console.ReadLine()));

            Console.WriteLine(item);
        }
    }
}

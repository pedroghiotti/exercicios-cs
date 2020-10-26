using System;

namespace _19_10_2020_Exercício_Média_Preços
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // Número de produtos dados pelo usuário.
            Product[] products; // Array que guarda os produtos dados.
            double totalPrice = 0; // Guarda o total da soma dos preços dos produtos dados.

            Console.Write("Numero de produtos dos quais preços deseja tirar a média: ");
            n = int.Parse(Console.ReadLine());
            products = new Product[n]; // Inicializa (é essa a palavra?) o Array 'products' com o tamanho dado pelo usuário. 

            for (int i = 0; i < n; i++) // Pede que defina um produto um número de vezes igual ao número de produtos que o usuário pediu para tirar a média. (Olhando agora, eu poderia ter usado o foreach).
            {
                Console.Write("\nProduto " + (i + 1) + ": ");
                string name = Console.ReadLine(); // Declara variável temporária para guardar o nome do produto dado.

                Console.Write("Preço do produto: ");
                double price = double.Parse(Console.ReadLine()); // Declara variável temporária para guardar o preço do produto dado.

                products[i] = new Product(name, price); // Declara um produto através do constructor da classe com os parâmetros dados pelo usuário na posição i do array.
            }

            foreach (var element in products) // Adiciona o preço de cada um dos produtos dados ao total.
            {
                totalPrice += element._price;
            }

            Console.WriteLine("\nA média dos preços dos produtos é " + (totalPrice / n)); // Escreve a média dividindo a soma dos preços pela quantidade de produtos.
        }
    }
}

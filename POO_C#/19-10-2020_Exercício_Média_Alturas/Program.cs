using System;

namespace _19_10_2020_Revisão_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // Número de valores que o usuário deseja introduzir.
            float[] heights; // Array que guarda os valores introduzidos.
            float totalHeight = 0; // Guarda a soma dos valores.

            Console.WriteLine("Qual o número de alturas que deseja tirar a média?");
            n = int.Parse(Console.ReadLine());
            heights = new float[n]; // Inicializa o array com o tamanho definido pelo usuário.

            for (int i = 0; i < n; i++)  // Pede ao usuário que introduza o valor de cada um dos elementos do array definido.
            {
                Console.Write("Altura " + (i + 1) + ":");
                heights[i] = float.Parse(Console.ReadLine());
            }

            foreach (var element in heights) // Soma cada valor dentro do array ao total.
            {
                totalHeight += element;
            }

            Console.WriteLine("\nA média das alturas dadas é " + (totalHeight / n)); // Escreve o resultado dado por dividir a soma das alturas dadas pelo seu número.
        }
    }
}

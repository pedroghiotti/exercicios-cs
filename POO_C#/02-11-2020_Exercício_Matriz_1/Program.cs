using System;

namespace _02_11_2020_Exercício_Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat; // Matriz
            int n; // Variável que representa a ordem da matriz quadrada
            string stringDiagonal = ""; // Guarda os números que compõem a diagonal da matriz em forma de string
            int negativeCount = 0; // Guarda o número de números negativos na matriz

            Console.Write("Ordem da matriz quadrada: ");
            n = int.Parse(Console.ReadLine());

            mat = new int[n, n]; // Cria a matriz do tamanho determinado pelo usuário

            Console.WriteLine("\nDigite os números que compõem a matriz separando-os por um espaço. Aperte enter cada vez que terminar uma linha até preencher a matriz.");

            for (int i = 0; i < n; i++) // Loop nas linhas da matriz
            {
                string[] matLineContents = Console.ReadLine().Split(' '); // Variável temporária. Guarda os conteúdos da próxima linha a ser preenchida
                for (int j = 0; j < n; j++) // Loop nas colunas da matriz
                {
                    mat[i, j] = int.Parse(matLineContents[j]); // Atribui os valores dados pelo usuário às posições na matriz
                    if (mat[i, j] < 0) // Se o valor for negativo, adiciona 1 à variável "negativeCount"
                    {
                        negativeCount++;
                    }
                }
                stringDiagonal += new string(" " + mat[i, i].ToString()); // Adiciona os números que compõem a diagonal à string separados por espaço
            }

            Console.WriteLine("\nDiagonal principal:" + stringDiagonal);
            Console.WriteLine("Quantidade de números negativos na matriz: " + negativeCount);
        }
    }
}

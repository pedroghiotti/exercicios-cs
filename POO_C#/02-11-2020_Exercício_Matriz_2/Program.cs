using System;

namespace _02_11_2020_Exercício_Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat; // Matriz
            int m, n; // Definem dimensões da matriz
            int target; // Número a ser encontrado na matriz

            Console.WriteLine("Digite as dimensões da matriz.");
            Console.Write("Linhas: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Colunas: ");
            n = int.Parse(Console.ReadLine());

            mat = new int[m, n]; // Cria a matriz do tamanho determinado pelo usuário

            Console.WriteLine("\nDigite os números que compõem a matriz separando-os por um espaço.\nAperte enter cada vez que terminar uma linha até preencher a matriz.\nPreencha a linha completamente. Caso contrário o sujeito que fez o programa vai ficar triste\npois não conseguiu resolver esse problema.");

            for (int l = 0; l < m; l++) // Loop nas linhas da matriz
            {
                string[] matLineContents = Console.ReadLine().Split(' '); // Variável temporária. Guarda os conteúdos da próxima linha a ser preenchida

                for (int c = 0; c < n; c++) // Loop nas colunas da matriz
                {
                    mat[l, c] = int.Parse(matLineContents[c]); // Atribui os valores dados pelo usuário às posições na matriz
                }
            }

            Console.WriteLine("\nEscreva agora um número. O programa dirá sua posição e, caso haja, os números em volta.");
            Console.Write("Número alvo: ");
            target = int.Parse(Console.ReadLine());

            for (int l = 0; l < m; l++) // Loop nas linhas da matriz
            {
                for (int c = 0; c < n; c++) // Loop nas colunas da matriz
                {
                    if (mat[l, c] == target) // Caso encontre o número pedido dá sua posição e confere se existem as posições em volta existem
                    {
                        Console.WriteLine("\nPosição do número alvo na matriz: (" + l + ", " + c + ").");

                        // Cima
                        if (l - 1 >= 0) // Caso a linha de cima exista...
                        {
                            Console.WriteLine("Acima: " + mat[l - 1, c]); // Escreve o número na linha de cima e na mesma coluna
                        }
                        else // Caso não exista...
                        {
                            Console.WriteLine("Acima: Fora dos limites da matriz."); // Avisa o usuário que está fora da matriz
                        }

                        // Baixo
                        if (l + 1 < m)
                        {
                            Console.WriteLine("Abaixo: " + mat[l + 1, c]);
                        }
                        else
                        {
                            Console.WriteLine("Abaixo: Fora dos limites da matriz.");
                        }

                        // Esquerda
                        if (c - 1 >= 0) // Caso a coluna à esquerda exista...
                        {
                            Console.WriteLine("À esquerda: " + mat[l, c - 1]); // Escreve o número na mesma linha e na coluna à esquerda
                        }
                        else // Caso não exista...
                        {
                            Console.WriteLine("À esquerda: Fora dos limites da matriz."); // Avisa o usuário que está fora da matriz
                        }

                        // Direita
                        if (c + 1 < n)
                        {
                            Console.WriteLine("À direita: " + mat[l, c + 1]);
                        }
                        else
                        {
                            Console.WriteLine("À direita: Fora dos limites da matriz.");
                        }
                    }
                }
            }
        }
    }
}

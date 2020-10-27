using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _26_10_2020_Exercício_Listas
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<string> list = new List<string>(); // Declaração da lista de strings 'list'.
            list.Add("Fábio"); // Adição de elementos à lista.
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("André");

            list.Insert(2, "Lucas"); // Adição de mais um elemento na posição 2, "empurrando" todos os elementos do 2 pra cima uma posição. 

            string s1 = list.Find(x => x[0] == 'A'); // Declaração das strings e uso do método 'Find' para atribuir a essas variáveis o primeiro e último elementos da lista que começam com 'A'.
            string s2 = list.FindLast(x => x[0] == 'A');

            foreach (string obj in list) // Escreve todos os elementos da lista.
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Qtd. de elementos na lista: " + list.Count); // Escreve a quantidade de elementos na lista.

            Console.WriteLine("Primeiro elemento que começa com 'A': " + s1); // Escreve as variáveis instanciadas algumas linhas acima.
            Console.WriteLine("Último elemento que começa com 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');  // Encontra o índice dos primeiro e último elementos da lista começados com 'A'e então atribui esses valores à variáveis e as escreve no console.
            Console.WriteLine("Primeira Posição de 'A': " +pos1); 
            int pos2 = list.FindLastIndex(x => x[0] == 'A'); 
            Console.WriteLine("Última Posição de 'A': " +pos2);
            
            Console.WriteLine("-------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);  // Cria uma nova lista 'list2' e a preenche com todos os elementos da lista 'list' que tem exatamente 5 caracteres. Esses são encontrados através do método 'List.FindAll()'.

            foreach (string obj in list2) // Escreve todos os elementos da lista 2.
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("===================");

            list.Remove("André"); // Remove da lista 1 o elemento especificado.

            foreach (string obj in list)  // Escreve todos os elementos da lista 1.
            { 
                Console.WriteLine(obj); 
            }
            
            Console.WriteLine("+++++++++++++++++++");

            list.RemoveAll(x => x[0] == 'W'); // Remove da lista 1, através do método 'List.RemoveAll()', todos os elementos que começam com 'W'.

            foreach (string obj in list) // Escreve todos os elementos da lista 1.
            { 
                Console.WriteLine(obj); 
            }
            
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");

            list.RemoveAt(3); // Remove da lista 1, através do método 'List.RemoveAt()', um elemento na posição especificada.

            foreach (string obj in list) // Escreve todos os elementos da lista 1.
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");

            list.RemoveRange(1, 2); // Remove da lista 1, através do método 'List.RemoveRange()', um número especificado de objetos a partir de uma dada posição.

            foreach (string obj in list) // Escreve todos os elementos da lista 1.
            { 
                Console.WriteLine(obj); 
            }
        }
    }
}

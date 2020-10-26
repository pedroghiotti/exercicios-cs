using System;

namespace _19_10_2020_Exercício_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] rooms = new Room[10]; // Instancia o array que guarda as instâncias da classe que define um quarto.
            for (int i = 0; i < 10; i++) // Cria e numera instâncias da classe 'Room' para preencher o array.
            {
                rooms[i] = new Room(i);
            }

            Console.Write("Número de hospedes (min 1, máx 10): ");
            int nOfGuests = int.Parse(Console.ReadLine());
            while (nOfGuests > 10 || nOfGuests < 1) // Confere se o número de hospedes dado pelo usuário é possível e, caso não, pede para que coloque outro número.
            {
                Console.Write("Número inválido. Tente novamente (min 1, máx 10): ");
                nOfGuests = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nOfGuests; i ++) // Pede para que o usuário preencha os dados de cada hospede.
            {
                Console.Write("\nNome do hospede: ");
                string name = Console.ReadLine(); // Variável temporária que guarda o nome do hospede.

                Console.Write("Quarto desejado (0 - 9): ");
                int roomNumber = int.Parse(Console.ReadLine()); // Variável temporária que guarda o número do quarto desejado.
                while (roomNumber < 0 || roomNumber > 9 || rooms[roomNumber]._guest != null) // Confere se o quarto pedido existe e se está ou não ocupado. Caso não exista ou estiver ocupado, pede para que selecione outro.
                {
                    Console.Write("Quarto ocupado ou inexistente. Selecione outro (0 - 9): ");
                    roomNumber = int.Parse(Console.ReadLine());
                }

                rooms[roomNumber].SetGuest(name); // Atribui o hospede ao quarto desejado.
            }

            Console.Clear(); // Limpa a tela do console.
            foreach (var element in rooms) // Relata a situação de cada um dos quartos da maneira descrita no método 'ToString()' da classe 'Room'.
            {
                Console.WriteLine(element);
            }
        }
    }
}

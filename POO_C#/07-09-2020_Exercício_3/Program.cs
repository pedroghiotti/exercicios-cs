using System;

namespace Exercício_3_07_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno - ");
            string name = Console.ReadLine();

            float grade1;
            do
            {
                Console.Write("Nota no primeiro trimestre - ");
                grade1 = float.Parse(Console.ReadLine());

                if (grade1 > 30)
                {
                    Console.WriteLine("\nA nota do primeiro trimestre não pode ultrapassar 30 pontos. Tente novamente.\n");
                }
            } while (grade1 > 30);

            float grade2;
            do
            {
                Console.Write("Nota no segundo trimestre - ");
                grade2 = float.Parse(Console.ReadLine());

                if (grade2 > 35)
                {
                    Console.WriteLine("\nA nota do segundo trimestre não pode ultrapassar 35 pontos. Tente novamente.\n");
                }
            } while (grade2 > 35);

            float grade3;
            do
            {
                Console.Write("Nota no terceiro trimestre - ");
                grade3 = float.Parse(Console.ReadLine());

                if (grade3 > 35)
                {
                    Console.WriteLine("\nA nota do terceiro trimestre não pode ultrapassar 35 pontos. Tente novamente.\n");
                }
            } while (grade3 > 35);

            Student student = new Student(name, grade1, grade2, grade3);

            Console.Clear();
            Console.WriteLine(student);
        }
    }
}

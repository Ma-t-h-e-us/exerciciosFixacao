using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"{i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}

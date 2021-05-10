using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}º número: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);
            Console.WriteLine($"o maior valor é {valores[0]} e o menor é {valores[9]}");
        }
    }
}

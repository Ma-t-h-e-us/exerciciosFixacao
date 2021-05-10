using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual ano atual?");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Você pode votar!");
            } else
            {
                Console.WriteLine("Você não pode votar :(");
            }
        }
    }
}

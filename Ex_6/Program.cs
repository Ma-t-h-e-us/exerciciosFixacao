using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}º nome: ");
                nomes[i] = (Console.ReadLine());
            }

            Console.WriteLine("Diga um nome");
            string nomeDif = Console.ReadLine();

            foreach (var item in nomes)
            {
                if (item == nomeDif)
                {
                    Console.WriteLine("ACHEI");

                }
                else
                {
                    Console.WriteLine("NÃO ACHEI");
                }

            }
        }
        }
    }

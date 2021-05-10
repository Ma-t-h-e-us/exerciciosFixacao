using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustível você quer usar? (A-álcool e G-gasolina)");
            string combustivel = Console.ReadLine().ToLower().Substring(0, 1);

            Console.WriteLine("Quantos litros deseja?");
            int litros = int.Parse(Console.ReadLine());

            double precoAlcool = 4.90;
            double precoGasolina = 5.30;

            switch (combustivel)
            {
                case "g":
                    if (litros <= 20)
                    {
                        double preco = (litros * (precoGasolina - (precoGasolina * 4 / 100)));
                        Console.WriteLine($"O preço fica R$ {Math.Round(preco, 2)}");
                    }
                    else
                    {
                        double preco = (litros * (precoGasolina - (precoGasolina * 6 / 100)));
                        Console.WriteLine($"O preço fica R$ {Math.Round(preco, 2)}");
                    }
                    break;

                case "a":
                    if (litros <= 20)
                    {
                        double preco = (litros * (precoAlcool - (precoAlcool * 3 / 100)));
                        Console.WriteLine($"O preço fica R$ {Math.Round(preco, 2)}");
                    }
                    else
                    {
                        double preco = (litros * (precoAlcool - (precoAlcool * 5 / 100)));
                        Console.WriteLine($"O preço fica R$ {Math.Round(preco, 2)}");
                    }
                    break;
                default:
                    
                    break;
            }


        }
    }
}

using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do produto?");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Qual a quantidade?");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do produto?");
            double precoProduto = double.Parse(Console.ReadLine());

            if (quantidadeProduto <= 5)
            {
                double precoTotal = Math.Round(((quantidadeProduto * precoProduto) - (quantidadeProduto * precoProduto * 2 / 100)), 2);
                Console.WriteLine($"O preço do {nomeProduto} fica R$ {precoTotal}");
            }

            if (quantidadeProduto > 5 && quantidadeProduto <= 10) {
            double precoTotal = Math.Round(((quantidadeProduto * precoProduto) - (quantidadeProduto * precoProduto * 3 / 100)), 2);
            Console.WriteLine($"O preço do {nomeProduto} fica R$ {precoTotal}");
            } else {
                double precoTotal = Math.Round(((quantidadeProduto * precoProduto) - (quantidadeProduto * precoProduto * 5 / 100)), 2);
                Console.WriteLine($"O preço do {nomeProduto} fica R$ {precoTotal}");
            }
        }
    }
}

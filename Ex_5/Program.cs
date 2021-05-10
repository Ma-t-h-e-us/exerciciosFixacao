using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            while (numero < 11){
            for (int segundoNumero = 1; segundoNumero < 11; segundoNumero++)
            {
                Console.WriteLine(numero * segundoNumero);
            } 
            numero++;
            }
        }
    }
}

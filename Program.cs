using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Zero");
                Environment.Exit(0);
            }

            if (numero > -1)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }

        }
    }
}

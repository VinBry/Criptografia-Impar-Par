using System;

namespace ContagemNumerosParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 0;
            int totalPares = 0;
            int totalImpares = 0;

            Console.WriteLine("Digite uma sequência de números (digite 0 para sair):");

            while (true)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                    break;

                totalNumeros++;

                if (numero % 2 == 0)
                {
                    totalPares++;
                    Console.WriteLine($"Número {numero} é par.");
                }
                else
                {
                    totalImpares++;
                    Console.WriteLine($"Número {numero} é ímpar.");
                }
            }

            Console.WriteLine($"Total de números: {totalNumeros}");
            Console.WriteLine($"Total de números pares: {totalPares}");
            Console.WriteLine($"Total de números ímpares: {totalImpares}");
        }
    }
}
using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"O valor final da variável SOMA é: {SOMA}");
            // O valor final será 91, pois:
            // SOMA = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 = 91
        }
    }
} 
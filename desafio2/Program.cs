using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Número na Sequência de Fibonacci");
            Console.WriteLine("----------------------------------------------");

            while (true)
            {
                Console.Write("\nDigite um número para verificar (ou 'sair' para encerrar): ");
                string input = Console.ReadLine()?.ToLower() ?? "";

                if (input == "sair")
                    break;

                if (int.TryParse(input, out int numero))
                {
                    bool pertence = VerificarFibonacci(numero);
                    Console.WriteLine($"\nO número {numero} {(pertence ? "pertence" : "não pertence")} à sequência de Fibonacci.");
                    
                    if (pertence)
                    {
                        Console.WriteLine("\nSequência até o número informado:");
                        ImprimirSequenciaAte(numero);
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            }
        }

        static bool VerificarFibonacci(int numero)
        {
            if (numero < 0) return false;
            if (numero == 0 || numero == 1) return true;

            int a = 0, b = 1;
            while (b <= numero)
            {
                if (b == numero) return true;
                int temp = a + b;
                a = b;
                b = temp;
            }
            return false;
        }

        static void ImprimirSequenciaAte(int limite)
        {
            int a = 0, b = 1;
            Console.Write($"{a}, {b}");
            
            while (b <= limite)
            {
                int temp = a + b;
                a = b;
                b = temp;
                if (b <= limite)
                    Console.Write($", {b}");
            }
            Console.WriteLine();
        }
    }
} 
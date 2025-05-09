using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inversor de String");
            Console.WriteLine("-----------------");

            while (true)
            {
                Console.Write("\nDigite uma string para inverter (ou 'sair' para encerrar): ");
                string input = Console.ReadLine() ?? "";

                if (input.ToLower() == "sair")
                    break;

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Por favor, digite uma string válida.");
                    continue;
                }

                string invertida = InverterString(input);
                Console.WriteLine($"\nString original: {input}");
                Console.WriteLine($"String invertida: {invertida}");
            }
        }

        static string InverterString(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim)
            {
                // Troca os caracteres
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;

                // Move os índices
                inicio++;
                fim--;
            }

            return new string(caracteres);
        }
    }
} 
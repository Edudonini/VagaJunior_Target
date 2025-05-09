using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio4
{
    public class Estado
    {
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }
        public decimal Percentual { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Dados de faturamento por estado
                var estados = new List<Estado>
                {
                    new Estado { Nome = "SP", Faturamento = 67836.43m },
                    new Estado { Nome = "RJ", Faturamento = 36678.66m },
                    new Estado { Nome = "MG", Faturamento = 29229.88m },
                    new Estado { Nome = "ES", Faturamento = 27165.48m },
                    new Estado { Nome = "Outros", Faturamento = 19849.53m }
                };

                // Calcula o total de faturamento
                decimal totalFaturamento = estados.Sum(e => e.Faturamento);

                // Calcula o percentual para cada estado
                foreach (var estado in estados)
                {
                    estado.Percentual = (estado.Faturamento / totalFaturamento) * 100;
                }

                // Exibe os resultados
                Console.WriteLine("Percentual de Representação por Estado");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"\nTotal de Faturamento: R$ {totalFaturamento:N2}");
                Console.WriteLine("\nDistribuição por Estado:");
                Console.WriteLine("----------------------");

                foreach (var estado in estados.OrderByDescending(e => e.Faturamento))
                {
                    Console.WriteLine($"{estado.Nome}:");
                    Console.WriteLine($"  Faturamento: R$ {estado.Faturamento:N2}");
                    Console.WriteLine($"  Percentual: {estado.Percentual:N2}%");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar os dados: {ex.Message}");
            }
        }
    }
} 
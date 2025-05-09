using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Desafio3
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Lê o arquivo JSON
                string jsonString = File.ReadAllText("dados.json");
                var faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(jsonString);

                // Filtra dias sem faturamento (valor = 0)
                var diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

                // Calcula o menor valor de faturamento
                var menorFaturamento = diasComFaturamento.Min(f => f.Valor);
                var diaMenorFaturamento = diasComFaturamento.First(f => f.Valor == menorFaturamento);

                // Calcula o maior valor de faturamento
                var maiorFaturamento = diasComFaturamento.Max(f => f.Valor);
                var diaMaiorFaturamento = diasComFaturamento.First(f => f.Valor == maiorFaturamento);

                // Calcula a média mensal (ignorando dias sem faturamento)
                var mediaMensal = diasComFaturamento.Average(f => f.Valor);

                // Conta dias com faturamento acima da média
                var diasAcimaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

                // Exibe os resultados
                Console.WriteLine("Análise de Faturamento Mensal");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"\nMenor valor de faturamento: R$ {menorFaturamento:F2} (Dia {diaMenorFaturamento.Dia})");
                Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento:F2} (Dia {diaMaiorFaturamento.Dia})");
                Console.WriteLine($"Média mensal: R$ {mediaMensal:F2}");
                Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");

                // Exibe detalhes dos dias acima da média
                Console.WriteLine("\nDias com faturamento acima da média:");
                foreach (var faturamento in diasComFaturamento.Where(f => f.Valor > mediaMensal).OrderBy(f => f.Dia))
                {
                    Console.WriteLine($"Dia {faturamento.Dia}: R$ {faturamento.Valor:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar os dados: {ex.Message}");
            }
        }
    }
} 
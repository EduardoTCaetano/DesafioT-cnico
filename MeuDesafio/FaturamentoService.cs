using System;
using System.IO;
using System.Linq;
using System.Text.Json;
public class FaturamentoService
{
    public static void AnalisarFaturamento()
    {
        string caminhoArquivo = "faturamento.json"; 

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Erro: Arquivo de faturamento não encontrado!");
            return;
        }

        try
        {
            string json = File.ReadAllText(caminhoArquivo);
            var dados = JsonSerializer.Deserialize<FaturamentoMensal>(json);

            if (dados == null || dados.FaturamentoDiario == null || dados.FaturamentoDiario.Length == 0)
            {
                Console.WriteLine("Erro: Faturamento vazio ou inválido!");
                return;
            }

            var faturamentoValido = dados.FaturamentoDiario.Where(f => f > 0).ToArray();

            Console.WriteLine($"Menor faturamento: {faturamentoValido.Min()}");
            Console.WriteLine($"Maior faturamento: {faturamentoValido.Max()}");
            Console.WriteLine($"Dias acima da média: {faturamentoValido.Count(f => f > faturamentoValido.Average())}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o faturamento: {ex.Message}");
        }
    }
}

public class FaturamentoMensal
{
    public double[] FaturamentoDiario { get; set; }
}

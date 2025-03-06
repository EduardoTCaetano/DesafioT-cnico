using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            bool pertence = FibonacciService.PertenceFibonacci(numero);
            Console.WriteLine(pertence ? "Pertence à sequência!" : "Não pertence.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }

        Console.WriteLine("\nInversão de string: Digite um texto:");
        string palavra = Console.ReadLine();
        Console.WriteLine($"Invertida: {StringService.InverterString(palavra)}");

        Console.WriteLine("\nAnalisando faturamento...");
        FaturamentoService.AnalisarFaturamento();
    }
}

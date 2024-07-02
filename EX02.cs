using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que digite o primeiro valor e converte a entrada para um inteiro
        Console.WriteLine("Digite o primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());

        // Solicita ao usuário que digite o segundo valor e converte a entrada para um inteiro
        Console.WriteLine("Digite o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());

        // Verifica se os valores são iguais
        if (valor1 == valor2)
        {
            // Se os valores forem iguais, exibe uma mensagem indicando que são idênticos
            Console.WriteLine("Os números são idênticos.");
        }
        else
        {
            // Se os valores forem diferentes, chama o método EncontrarMaior para descobrir o maior valor
            int maior = EncontrarMaior(valor1, valor2);
            // Exibe o maior valor encontrado
            Console.WriteLine($"O maior valor é: {maior}");
        }
    }

    // Método que retorna o maior de dois valores inteiros
    static int EncontrarMaior(int a, int b)
    {
        // Utiliza uma expressão condicional (operador ternário) para retornar o maior valor entre a e b
        return a > b ? a : b;
    }
}

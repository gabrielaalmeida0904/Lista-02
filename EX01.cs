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

        // Verifica se os valores são iguais e solicita novos valores até que sejam distintos
        while (valor1 == valor2)
        {
            Console.WriteLine("Os valores devem ser distintos. Digite um valor diferente para o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
        }

        // Chama o método EncontrarMaior para determinar qual dos dois valores é maior
        int maior = EncontrarMaior(valor1, valor2);

        // Exibe o maior valor encontrado
        Console.WriteLine($"O maior valor é: {maior}");
    }

    // Método que retorna o maior de dois valores inteiros
    static int EncontrarMaior(int a, int b)
    {
        // Utiliza uma expressão condicional (operador ternário) para retornar o maior valor entre a e b
        return a > b ? a : b;
    }
}

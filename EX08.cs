using System;
class Programa
{
    static void Main(string[] args)
    {
        // Solicita o valor do lado A ao usuário
        Console.WriteLine("Digite o valor do lado A:");
        double ladoA = double.Parse(Console.ReadLine());

        // Solicita o valor do lado B ao usuário
        Console.WriteLine("Digite o valor do lado B:");
        double ladoB = double.Parse(Console.ReadLine());

        // Solicita o valor do lado C ao usuário
        Console.WriteLine("Digite o valor do lado C:");
        double ladoC = double.Parse(Console.ReadLine());

        // Verifica se os lados fornecidos formam um triângulo retângulo
        if (FormaTrianguloRetangulo(ladoA, ladoB, ladoC))
        {
            Console.WriteLine("Os valores formam um triângulo retângulo.");
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo retângulo.");
        }
    }

    // Método para verificar se os lados fornecidos formam um triângulo retângulo
    static bool FormaTrianguloRetangulo(double lado1, double lado2, double lado3)
    {
        // Determina qual lado é o maior
        double maiorLado = Math.Max(lado1, Math.Max(lado2, lado3));

        // Verifica a condição do teorema de Pitágoras para o maior lado
        if (maiorLado == lado1)
        {
            return Math.Pow(lado1, 2) == Math.Pow(lado2, 2) + Math.Pow(lado3, 2);
        }
        else if (maiorLado == lado2)
        {
            return Math.Pow(lado2, 2) == Math.Pow(lado1, 2) + Math.Pow(lado3, 2);
        }
        else
        {
            return Math.Pow(lado3, 2) == Math.Pow(lado1, 2) + Math.Pow(lado2, 2);
        }
    }
}

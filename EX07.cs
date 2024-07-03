using System;
class Programa
{
    static void Main(string[] args)
    {
        // Solicita o valor do primeiro lado ao usuário
        Console.WriteLine("Digite o valor do primeiro lado:");
        double primeiroLado = double.Parse(Console.ReadLine());

        // Solicita o valor do segundo lado ao usuário
        Console.WriteLine("Digite o valor do segundo lado:");
        double segundoLado = double.Parse(Console.ReadLine());

        // Solicita o valor do terceiro lado ao usuário
        Console.WriteLine("Digite o valor do terceiro lado:");
        double terceiroLado = double.Parse(Console.ReadLine());

        // Verifica se os lados fornecidos formam um triângulo
        if (FormaTriangulo(primeiroLado, segundoLado, terceiroLado))
        {
            // Verifica o tipo de triângulo com base nos lados fornecidos
            if (primeiroLado == segundoLado && segundoLado == terceiroLado)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (primeiroLado == segundoLado || primeiroLado == terceiroLado || segundoLado == terceiroLado)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os valores fornecidos não formam um triângulo.");
        }
    }

    // Método para verificar se os lados fornecidos formam um triângulo
    static bool FormaTriangulo(double lado1, double lado2, double lado3)
    {
        return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
    }
}

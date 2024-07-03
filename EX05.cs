using System;
class Programa
{
    static void Main(string[] args)
    {
        // Solicita o valor da base do retângulo ao usuário
        Console.WriteLine("Digite o valor da base do retângulo:");
        double valorBase = double.Parse(Console.ReadLine());

        // Solicita o valor da altura do retângulo ao usuário
        Console.WriteLine("Digite o valor da altura do retângulo:");
        double valorAltura = double.Parse(Console.ReadLine());

        // Calcula a área do retângulo
        double areaRetangulo = valorBase * valorAltura;

        // Exibe a área calculada
        Console.WriteLine($"A área do retângulo é: {areaRetangulo}");

        // Verifica se a área do retângulo é maior que 100 e exibe uma mensagem correspondente
        if (areaRetangulo > 100)
        {
            Console.WriteLine("Terreno grande");
        }
        else
        {
            Console.WriteLine("Terreno pequeno");
        }
    }
}

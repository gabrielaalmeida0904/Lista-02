using System;
class Programa
{
    static void Main()
    {
        // Solicita ao usuário para entrar com a nota P1
        Console.Write("Digite a nota da P1: ");
        double notaP1 = Convert.ToDouble(Console.ReadLine());

        // Média necessária para aprovação
        double mediaAprovacao = 5.0;

        // Calcula a nota necessária em P2 para que a média seja igual a 5.0
        // Fórmula derivada da média: mediaAprovacao = (P1 + 2*P2) / 3
        // => 3 * mediaAprovacao = P1 + 2*P2
        // => 2*P2 = 3 * mediaAprovacao - P1
        // => P2 = (3 * mediaAprovacao - P1) / 2
        double notaP2Necessaria = (3 * mediaAprovacao - notaP1) / 2;

        // Exibe a nota necessária para P2 com duas casas decimais
        Console.WriteLine($"Para ser aprovado, você precisa tirar pelo menos {notaP2Necessaria:F2} na P2.");
    }
}

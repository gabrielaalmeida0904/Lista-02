using System;
class Programa
{
    static void Main()
    {
        // Solicita ao usuário para entrar com as notas P1 e P2
        Console.Write("Digite a nota da P1: ");
        double notaP1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da P2: ");
        double notaP2 = Convert.ToDouble(Console.ReadLine());

        // Calcula a média conforme a fórmula dada
        double media = (notaP1 + 2 * notaP2) / 3;

        // Exibe a média calculada com duas casas decimais
        Console.WriteLine($"Média do aluno: {media:F2}");

        // Determina a situação final do aluno com base na média de aprovação
        if (media >= 5.0)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}

using System;
class Programa
{
    static void Main(string[] args)
    {
        // Solicita o peso da pessoa em kg ao usuário
        Console.WriteLine("Digite o peso da pessoa em kg:");
        double pesoPessoa = double.Parse(Console.ReadLine());

        // Solicita a altura da pessoa em metros ao usuário
        Console.WriteLine("Digite a altura da pessoa em metros:");
        double alturaPessoa = double.Parse(Console.ReadLine());

        // Calcula o IMC da pessoa
        double imcPessoa = CalcularIMC(pesoPessoa, alturaPessoa);

        // Exibe o IMC calculado
        Console.WriteLine($"O IMC da pessoa é: {imcPessoa}");

        // Determina a faixa de IMC da pessoa e exibe uma mensagem correspondente
        if (imcPessoa < 20)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imcPessoa >= 20 && imcPessoa < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("Acima do peso");
        }
    }

    // Método para calcular o Índice de Massa Corporal (IMC)
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }
}

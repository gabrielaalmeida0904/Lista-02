using System;
class Programa
{
    static void Main(string[] args)
    {
        // Solicita o peso da pessoa em kg ao usuário
        Console.WriteLine("Digite o peso da pessoa em kg:");
        double peso = double.Parse(Console.ReadLine());

        // Solicita a altura da pessoa em metros ao usuário
        Console.WriteLine("Digite a altura da pessoa em metros:");
        double altura = double.Parse(Console.ReadLine());

        // Solicita o sexo da pessoa (M para masculino, F para feminino) ao usuário
        Console.WriteLine("Digite o sexo da pessoa (M para masculino, F para feminino):");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        // Calcula o IMC da pessoa
        double imc = CalcularIMC(peso, altura);

        // Exibe o IMC calculado
        Console.WriteLine($"O IMC da pessoa é: {imc}");

        // Verifica o sexo da pessoa e determina a faixa de IMC correspondente
        if (sexo == 'M')
        {
            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
        else if (sexo == 'F')
        {
            if (imc < 19)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 19 && imc < 24)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, insira M para masculino ou F para feminino.");
        }
    }

    // Método para calcular o Índice de Massa Corporal (IMC)
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }
}

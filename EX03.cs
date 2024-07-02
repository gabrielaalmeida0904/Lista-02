using System;
class Programa
{
    static void Main(string[] args)
{
    // Solicita o primeiro valor ao usuário
    Console.WriteLine("Digite o primeiro valor:");
    int primeiroValor = int.Parse(Console.ReadLine());

    // Solicita o segundo valor ao usuário
    Console.WriteLine("Digite o segundo valor:");
    int segundoValor = int.Parse(Console.ReadLine());

    // Solicita o terceiro valor ao usuário
    Console.WriteLine("Digite o terceiro valor:");
    int terceiroValor = int.Parse(Console.ReadLine());

    // Encontra o maior valor entre os três valores fornecidos
    string maiorValor = DeterminarMaior(primeiroValor, segundoValor, terceiroValor);
    Console.WriteLine($"O(s) maior(es) valor(es) é(são): {maiorValor}");
}

// Método para determinar o maior valor entre três inteiros
static string DeterminarMaior(int valorA, int valorB, int valorC)
{
    // Verifica se o valorA é maior que os outros dois valores
    if (valorA > valorB && valorA > valorC)
    {
        return valorA.ToString();
    }
    // Verifica se o valorB é maior que os outros dois valores
    else if (valorB > valorA && valorB > valorC)
    {
        return valorB.ToString();
    }
    // Verifica se o valorC é maior que os outros dois valores
    else if (valorC > valorA && valorC > valorB)
    {
        return valorC.ToString();
    }
    // Verifica se todos os valores são iguais
    else if (valorA == valorB && valorB == valorC)
    {
        return $"{valorA}, {valorB} e {valorC} são iguais";
    }
    // Verifica se valorA e valorB são iguais
    else if (valorA == valorB)
    {
        return $"{valorA} e {valorB} são iguais";
    }
    // Verifica se valorA e valorC são iguais
    else if (valorA == valorC)
    {
        return $"{valorA} e {valorC} são iguais";
    }
    // Verifica se valorB e valorC são iguais
    else if (valorB == valorC)
    {
        return $"{valorB} e {valorC} são iguais";
    }
    // Caso não se encaixe em nenhuma das verificações anteriores
    else
    {
        return $"{valorA}, {valorB} e {valorC} são iguais";
    }
}
}

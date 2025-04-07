using System;

class Program
{
    static int ContarOcorrencias(int[] array, int num)
    {
        int contagem = 0;
        foreach (int n in array)
            if (n == num) contagem++;
        return contagem;
    }

    static void Main()
    {
        int[] numeros = { 10, 20, 30, 20, 40, 50, 20 };
        int procurar = 20;
        Console.WriteLine($"O número {procurar} aparece {ContarOcorrencias(numeros, procurar)} vezes.");
    }
}

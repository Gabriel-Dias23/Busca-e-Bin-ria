using System;

class Program
{
    static int BuscaComSentinela(int[] array, int x)
    {
        int n = array.Length;
        int[] novoArray = new int[n + 1];
        Array.Copy(array, novoArray, n);
        novoArray[n] = x;

        int i = 0;
        while (novoArray[i] != x) i++;

        return (i == n) ? -1 : i;
    }

    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int procurar = 30;
        Console.WriteLine($"Índice encontrado: {BuscaComSentinela(numeros, procurar)}");
    }
}

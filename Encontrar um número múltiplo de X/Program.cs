using System;

class Program
{
    static int MultiploDeX(int[] array, int x)
    {
        foreach (int num in array)
            if (num % x == 0) return num;
        return -1;
    }

    static void Main()
    {
        int[] numeros = { 3, 7, 10, 14, 25 };
        int x = 5;
        int resultado = MultiploDeX(numeros, x);

        Console.WriteLine(resultado != -1 ? $"Primeiro múltiplo de {x}: {resultado}" : "Nenhum múltiplo encontrado.");
    }
}

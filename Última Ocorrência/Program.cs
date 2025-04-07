using System;

class Program
{
    static int UltimaOcorrencia(int[] array, int num)
    {
        int indice = -1;
        for (int i = 0; i < array.Length; i++)
            if (array[i] == num) indice = i;
        return indice;
    }

    static void Main()
    {
        int[] numeros = { 10, 20, 30, 20, 40, 50, 20 };
        int procurar = 20;
        Console.WriteLine($"Última ocorrência no índice {UltimaOcorrencia(numeros, procurar)}");
    }
}

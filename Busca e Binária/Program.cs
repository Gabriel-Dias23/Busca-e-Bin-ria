using System;

class Program
{
    static int BuscaSequencial(int[] array, int num)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == num) return i;
        return -1;
    }

    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int procurar = 30;
        int indice = BuscaSequencial(numeros, procurar);

        Console.WriteLine(indice != -1 ? $"Número {procurar} encontrado no índice {indice}." : "Número não encontrado.");
    }
}

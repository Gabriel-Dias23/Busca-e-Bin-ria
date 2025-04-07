using System;

class Program
{
    static int PrimeiroPar(int[] array)
    {
        foreach (int num in array)
            if (num % 2 == 0) return num;
        return -1;
    }

    static void Main()
    {
        int[] numeros = { 3, 7, 11, 14, 25 };
        Console.WriteLine($"Primeiro número par: {PrimeiroPar(numeros)}");
    }
}

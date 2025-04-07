using System;

class Program
{
    static (int, int) MaiorMenor(int[] array)
    {
        int maior = array[0], menor = array[0];
        foreach (int num in array)
        {
            if (num > maior) maior = num;
            if (num < menor) menor = num;
        }
        return (maior, menor);
    }

    static void Main()
    {
        int[] numeros = { 5, 8, 3, 12, 7 };
        var (maior, menor) = MaiorMenor(numeros);
        Console.WriteLine($"Maior: {maior}, Menor: {menor}");
    }
}

using System;

class Program
{
    static int BuscaString(string[] array, string nome)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == nome) return i;
        return -1;
    }

    static void Main()
    {
        string[] nomes = { "Ana", "Bruno", "Carlos", "Daniela" };
        string procurar = "Carlos";
        int indice = BuscaString(nomes, procurar);

        Console.WriteLine(indice != -1 ? $"Nome {procurar} encontrado no índice {indice}." : "Nome não encontrado.");
    }
}

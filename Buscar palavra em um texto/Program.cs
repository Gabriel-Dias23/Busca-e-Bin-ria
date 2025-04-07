using System;

class Program
{
    static int BuscarPalavra(string texto, string palavra)
    {
        return texto.IndexOf(palavra, StringComparison.OrdinalIgnoreCase);
    }

    static void Main()
    {
        string texto = "A programação é divertida e desafiadora.";
        string palavra = "divertida";
        int indice = BuscarPalavra(texto, palavra);

        Console.WriteLine(indice != -1 ? $"Palavra encontrada no índice {indice}" : "Palavra não encontrada.");
    }
}

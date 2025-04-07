int BuscaPalavra(string[] dicionario, string palavra)
{
    int inicio = 0, fim = dicionario.Length - 1;
    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        int comparacao = string.Compare(dicionario[meio], palavra, StringComparison.OrdinalIgnoreCase);
        if (comparacao == 0) return meio;
        else if (comparacao < 0) inicio = meio + 1;
        else fim = meio - 1;
    }
    return -1;
}

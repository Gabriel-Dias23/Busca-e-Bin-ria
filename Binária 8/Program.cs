int PrimeiraOcorrencia(int[] array, int alvo)
{
    int resultado = -1, inicio = 0, fim = array.Length - 1;
    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] == alvo)
        {
            resultado = meio;
            fim = meio - 1;
        }
        else if (array[meio] < alvo) inicio = meio + 1;
        else fim = meio - 1;
    }
    return resultado;
}

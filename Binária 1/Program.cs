int BuscaBinaria(int[] array, int alvo)
{
    int inicio = 0, fim = array.Length - 1;
    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] == alvo) return meio;
        else if (array[meio] < alvo) inicio = meio + 1;
        else fim = meio - 1;
    }
    return -1; // não encontrado
}

int PosicaoInsercao(int[] array, int x)
{
    int inicio = 0, fim = array.Length;
    while (inicio < fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] < x) inicio = meio + 1;
        else fim = meio;
    }
    return inicio;
}

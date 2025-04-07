int NumeroMaisProximo(int[] array, int x)
{
    int inicio = 0, fim = array.Length - 1;
    int maisProximo = array[0];

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (Math.Abs(array[meio] - x) < Math.Abs(maisProximo - x))
            maisProximo = array[meio];

        if (array[meio] < x) inicio = meio + 1;
        else fim = meio - 1;
    }

    return maisProximo;
}

﻿int MenorMaiorQueX(int[] array, int x)
{
    int resultado = -1;
    int inicio = 0, fim = array.Length - 1;
    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        if (array[meio] > x)
        {
            resultado = array[meio];
            fim = meio - 1;
        }
        else inicio = meio + 1;
    }
    return resultado;
}

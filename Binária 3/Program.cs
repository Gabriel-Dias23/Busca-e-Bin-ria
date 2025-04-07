object buscaBinariaIndices = BuscaBinaria;

List<int> BuscaBinaria(int[] array, int alvo)
{
    List<int> indices = new();
    int index = BuscaBinaria(array, alvo);
    if (index == -1) return indices;

    // Verifica elementos anteriores
    int i = index;
    while (i >= 0 && array[i] == alvo)
    {
        indices.Add(i);
        i--;
    }

    // Verifica elementos posteriores
    i = index + 1;
    while (i < array.Length && array[i] == alvo)
    {
        indices.Add(i);
        i++;
    }

    indices.Sort();
    return indices;
}

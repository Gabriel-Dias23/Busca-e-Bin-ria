static int PrimeiroParOuImpar(int[] array, bool par)
{
    foreach (var num in array)
        if ((num % 2 == 0) == par) return num; 
    return -1;
}

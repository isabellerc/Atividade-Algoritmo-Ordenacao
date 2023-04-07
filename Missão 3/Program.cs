// Missão 3
int[] vetor = new int[] { 9, 3, 4, 1, 5 };

Console.WriteLine("Vetor original:");
ImprimirVetor(vetor);

// Ordenação em ordem crescente
BubbleSortCrescente(vetor);
Console.WriteLine("Vetor ordenado em ordem crescente:");
ImprimirVetor(vetor);

// Ordenação em ordem decrescente
BubbleSortDecrescente(vetor);
Console.WriteLine("Vetor ordenado em ordem decrescente:");
ImprimirVetor(vetor);
    

    static void BubbleSortCrescente(int[] vetor)
{
    int tamanho = vetor.Length;
    for (int i = 0; i < tamanho - 1; i++)
    {
        for (int j = 0; j < tamanho - 1 - i; j++)
        {
            if (vetor[j] > vetor[j + 1])
            {
                int auxiliar = vetor[j];
                vetor[j] = vetor[j + 1];
                vetor[j + 1] = auxiliar;
            }
        }
    }
}

static void BubbleSortDecrescente(int[] vetor)
{
    int tamanho = vetor.Length;
    for (int i = 0; i < tamanho - 1; i++)
    {
        for (int j = 0; j < tamanho - 1 - i; j++)
        {
            if (vetor[j] < vetor[j + 1])
            {
                int auxiliar = vetor[j];
                vetor[j] = vetor[j + 1];
                vetor[j + 1] = auxiliar;
            }
        }
    }
}

static void ImprimirVetor(int[] vetor)
{
    foreach (var elemento in vetor)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}


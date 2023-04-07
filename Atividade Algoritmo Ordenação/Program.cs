// Missao 1

Console.WriteLine("O vetor a seguir será ordenado de acordo com a sua escolha: 9, 3, 4, 1, 5");
Console.WriteLine();
Console.Write("Digite C para ordená-lo de forma crescente e D para ordená-lo de forma decrescente: ");
char ordenacao = char.Parse(Console.ReadLine());

if (ordenacao == 'C'|| ordenacao == 'c') { 

int[] vetor = new int[5] { 9, 3, 4, 1, 5 };

int auxiliar = 0;
for (int i = 0; i < vetor.Length - 1; i++)
{
    if (vetor[i] > vetor[i + 1])
    {
        auxiliar = vetor[i + 1];
        vetor[i + 1] = vetor[i];
        vetor[i] = auxiliar;

        int j = i - 1;
        while (j >= 0 && auxiliar < vetor[j])
        {
            auxiliar = vetor[j + 1];
            vetor[j + 1] = vetor[j];
            vetor[j] = auxiliar;

            j--;
        }
    }
}

Console.Write("Aqui estão os valores do vetor em ordem crescente:");
for (int o = 0; o < vetor.Length; o++)
{
    Console.Write($"{vetor[o]}, ");
}

}

else { 
//vetor Decrescente:
int[] vetorDecrescente = new int[5] { 9, 3, 4, 1, 5 };

int auxiliar1 = 0;
for (int i = 0; i < vetorDecrescente.Length - 1; i++)
{
    if (vetorDecrescente[i] < vetorDecrescente[i + 1]) // Alteração na comparação
    {
        auxiliar1 = vetorDecrescente[i + 1];
        vetorDecrescente[i + 1] = vetorDecrescente[i];
        vetorDecrescente[i] = auxiliar1;

        int j = i - 1;
        while (j >= 0 && auxiliar1 > vetorDecrescente[j]) // Alteração na comparação
        {
            auxiliar1 = vetorDecrescente[j + 1];
            vetorDecrescente[j + 1] = vetorDecrescente[j];
            vetorDecrescente[j] = auxiliar1;

            j--;
        }
    }
}

Console.Write("Aqui estão os valores do vetor em ordem decrescente:");
for (int p = 0; p < vetorDecrescente.Length; p++)
{
    Console.Write($"{vetorDecrescente[p]}, ");
}

}

Console.WriteLine();
Console.WriteLine();


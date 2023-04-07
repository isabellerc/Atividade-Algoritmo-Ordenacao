//Missão 2

Console.WriteLine("O vetor de palavras a ser ordenado é: lápis, caneta, papel, borracha, apontador");
Console.WriteLine();

string[] vetorPalavras = new string[] { "lápis", "caneta", "papel", "borracha", "apontador" };

// Ordenação em ordem crescente
Array.Sort(vetorPalavras);

Console.WriteLine("Vetor ordenado em ordem crescente:");
foreach (var palavra in vetorPalavras)
{
    Console.WriteLine($"- {palavra}");
}

// Ordenação em ordem decrescente
Array.Sort(vetorPalavras);
Array.Reverse(vetorPalavras);

Console.WriteLine();
Console.WriteLine("Vetor ordenado em ordem decrescente:");
foreach (var palavra in vetorPalavras)
{
    Console.WriteLine($"- {palavra}");
}
    

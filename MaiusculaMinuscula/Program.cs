// 3. Faça um programa que leia um vetor de caracteres de 10 posições e converta as vogais de minusculo para maiusculo;

int tamanho = 10;
char[] palavra = new char[tamanho];
char[] vogais = new char[5] { 'a', 'e', 'i', 'o', 'u' };
char[] maiusculas = new char[5] { 'A', 'E', 'I', 'O', 'U' };

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª letra:");
    palavra[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (palavra[i] == vogais[j])
        {
            palavra[i] = maiusculas[j];
        }
    }
}
for (int i = 0; i < tamanho; i++)
{
    Console.Write(palavra[i]);
}

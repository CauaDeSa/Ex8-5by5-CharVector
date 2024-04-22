int size = 10;
char[] palavra = new char[size];

Console.WriteLine("\nCharactere input");

for (int i = 0; i < size; i++)
{
    Console.Write($"\nType the {i + 1}° charactere: ");
    palavra[i] = char.Parse(Console.ReadLine());
}

Console.WriteLine("\nVowels");

for (int i = 0; i < size; i++)
{
    if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
        Console.Write($"{palavra[i]} ");
}

Console.WriteLine("\n\nConsonants");

for (int i = 0; i < size; i++)
{
    if (palavra[i] != 'a' && palavra[i] != 'e' && palavra[i] != 'i' && palavra[i] != 'o' && palavra[i] != 'u')
        Console.Write($"{palavra[i]} ");
}

Console.WriteLine("\n\nPress any key to continue...");
Console.ReadKey();
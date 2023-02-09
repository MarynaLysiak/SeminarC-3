// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


string? GetNumber(string text)
{
    System.Console.WriteLine(text);
    return System.Console.ReadLine();
}

string? abc = GetNumber("Введите число N: ");
int length = abc!.Length;

System.Console.WriteLine($"в числе {abc} - {length} цифр");
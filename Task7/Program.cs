// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int Number = GetNumber("Введите число N: ");
int factorial = 1;
for (int i = 2; i <=Number; i++)
    {
      factorial = factorial * i;
    }

System.Console.WriteLine(factorial);


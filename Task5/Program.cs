// Напишите программу, которая берет на входе число, а выдает сумму чисел от 1 до А

// System.Console.WriteLine("Введите число А: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// for (int i = 1; i <= num ; i++)
// {
//     result+=i; //result = result + i
// }
// System.Console.WriteLine($" Сумма чисел от 1 до {num} равна {result}");

// Решение с использованием функций

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumElements(int A)
{
    int result = 0;
    for (int i = 1; i <= A; i++)
    {
        result += i; // result = result + i;
    }

    return result;
}

int num = GetNumber("Введите число А: ");
int res = GetSumElements(num);

System.Console.WriteLine($"Сумма чисел от 1 до {num} = {res}");
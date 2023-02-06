// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count <= N)
// {
//     System.Console.Write(Math.Pow(count, 2) + " ");
//     count ++;
// }

for (int i = 1; i <= N; i++)
{
    System.Console.Write(Math.Pow(i, 2) + " ");
}

//когда известно, до какого числа цикл продолжается, лучше цикл For использовать
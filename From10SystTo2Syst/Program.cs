﻿//  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3 -> 11
// 2 -> 10

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string st = "";

// while (n != 0)
// {
//     st += n % 2;
//     n = n / 2;
// }

// for (int i = st.Length - 1; i >= 0; i--)
// {
//     System.Console.Write(st[i]);
// }
// System.Console.WriteLine();


// решение с рекурсией
// void GetBinatyView(int number)
// {
// if (number <= 0) return;
// GetBinatyView(number / 2);
// System.Console.Write(number % 2);
// }

// System.Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// GetBinatyView(N);


System.Console.WriteLine("Введите число ");
int value = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(Convert.ToString(value, 2));

﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int GetIndexOfElement(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 21);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
    System.Console.WriteLine();
    }
}

int row = GetIndexOfElement("Введите номер строки искомого элемента: ");
int column = GetIndexOfElement("Введите номер столбца искомого элемента: ");
System.Console.WriteLine();
int[,] myMatrix = GenerateMatrix(5, 5);
PrintMatrix(myMatrix);
System.Console.WriteLine();

if (row > myMatrix.GetLength(0) || column > myMatrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {row} строки и столбца {column}  равно {myMatrix[row-1,column-1]}");
}

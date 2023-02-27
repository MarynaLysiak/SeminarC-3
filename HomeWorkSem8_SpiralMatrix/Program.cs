// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GenerateSpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int number = 1;
    int i = 0;
    int j = 0;
    int NoElements = size * size;

    while (number <= 4 * 4) // 16 итераций заполнения
    {
        matrix[i, j] = number;
        if (i <= j + 1 && i + j <  size- 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        number++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


 

Console.Clear();
int[,] myMatrix = GenerateSpiralMatrix(4);
PrintMatrix(myMatrix);
System.Console.WriteLine();
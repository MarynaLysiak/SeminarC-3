// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int GetNoRowsCols(string text)
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
        matrix[i, j] = rand.Next(0, 11);
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
        System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Sort(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int k = matr.GetLength(1) - 1; k > 0 ; k--) 
        {
            for (int j = 0; j < k; j++)   
            {
                if (matr[i,j] < matr[i,j+1]) 
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, j+1];
                    matr[i, j+1] = temp;
                }
            }
        }
    }
}




Console.Clear();
int rows = GetNoRowsCols("Введите количество строк матрицы: ");
int columns = GetNoRowsCols("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(rows, columns);
PrintMatrix(myMatrix);
System.Console.WriteLine();
Sort(myMatrix);
PrintMatrix(myMatrix);
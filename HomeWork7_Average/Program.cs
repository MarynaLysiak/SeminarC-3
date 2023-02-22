// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int GetMatrixSize(string text)
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

int row = GetMatrixSize("Введите количество строк в таблице: ");
int column = GetMatrixSize("Введите количество стоблцов с таблице: ");
System.Console.WriteLine();
int[,] myMatrix = GenerateMatrix(5, 5);
PrintMatrix(myMatrix);
System.Console.WriteLine();


for (int j = 0; j < myMatrix.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        average = (average + myMatrix[i, j]);
    }
    average = average / column;

    Console.Write($"{Math.Round(average, 3)}; ");
}


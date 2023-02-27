// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GenerateMatrix()
{
    Random rand = new Random();
    int[,] matrix = new int[6, 3];
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


int FindRowWithMinSum(int[,] matrix) 
{
    int MinRowIndex = 0;
    int MinSumElements = 0;
    int SumRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)  
            {
                MinSumElements += matrix[i, j];
                SumRow += matrix[i, j]; 
            }
            else SumRow += matrix[i, j];
        }
        if (SumRow < MinSumElements)
        {
            MinSumElements = SumRow;
            MinRowIndex = i;
        }
        SumRow = 0;
    }
    return (MinRowIndex+1);
}


Console.Clear();
int[,] myMatrix = GenerateMatrix();
PrintMatrix(myMatrix);
System.Console.WriteLine($"Строка с минимальной суммой элементов - {FindRowWithMinSum(myMatrix)}");
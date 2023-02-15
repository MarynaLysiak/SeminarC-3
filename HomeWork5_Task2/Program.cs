// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100); //рандом в промежутке 0-100, чтобы сильно больших чисел не было
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountSum(int[] MyArray)
{
    int sum = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (i%2 == 0)
        {
        sum = sum + MyArray[i];
        }
    }
    return sum;
}

int[] MyArray = GetArray(10);
PrintArray(MyArray);
int result = CountSum(MyArray);
System.Console.WriteLine($"Сумма всех четных чисел массива = {result}");
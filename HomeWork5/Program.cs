// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); // класс Random - генерация случайных чисел. Next - 
    }
    return array;
}

void PrintArray(int[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] MyArray = GetArray(10);
PrintArray(MyArray);
int result = CountPositive(MyArray);
System.Console.WriteLine($"В массиве {result} четных чисел");
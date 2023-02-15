// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] GenerateArray(int size, int leftRange, int rightRange)
{
int[] array = new int[size];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
}
return array;
}

void PrintArray(int[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

bool FindNumber(int[] array, int number)
{
for(int i = 0; i<array.Length; i++)
{
if(array[i] == number)
{
return true;
}
}
return false;
}

int[] myArray = GenerateArray(6, -9, 9);

int number = 7;

PrintArray(myArray);

if(FindNumber(myArray, number))
{
System.Console.WriteLine("Да, такой элемент есть");
}
else
{
    System.Console.WriteLine("Нет, такого элемиента нет");
}

// int[] arr = {1, 2, 3, 0, 7};
// System.Console.WriteLine(Array.IndexOf(arr, 9)); - 
//использование IndexOf класса Array - поиск индекса искомого элемента 
// индекс оф выдает -1, если искомый элемент не найден, или выдает индекс элемента
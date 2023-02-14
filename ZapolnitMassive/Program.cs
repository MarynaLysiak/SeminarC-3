// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


int[] GenerateArray(int size, int LeftRange, int RightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(LeftRange, RightRange +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(",", array)+"]");
}


int[] MyArray = GenerateArray(10, 1, 22);
PrintArray(MyArray);

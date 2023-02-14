// /  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GenerateArray(int size, int LeftRange, int RightRange) // генерируем массив случайными цифрами
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(LeftRange, RightRange +1);
    }
    return array;
}

void PrintArray(int[] array) //Вывод массива в консоль
{
    System.Console.WriteLine("["+string.Join(",", array)+"]");
}

void Change(int[] array)  // замена положительных элементов отрицательными и наоборот
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] myArray = GenerateArray(10, -20, 20);
PrintArray(myArray);
Change(myArray);
PrintArray(myArray);
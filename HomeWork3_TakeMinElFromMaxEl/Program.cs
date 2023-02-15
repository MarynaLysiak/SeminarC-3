// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 3); 
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double FindMin(double[] array)
{
    double MinEl = array[0]; 
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < MinEl)
        {
            MinEl = array[i];
        }
    }
    return MinEl;
}

double FindMax(double[] array)
{
    double MaxEl = array[0]; 
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxEl)
        {
            MaxEl = array[i];
        }
    }
    return MaxEl;
}

double[] MyArray = GetArray(10);
PrintArray(MyArray);
System.Console.WriteLine($"Минимальный элемент = {FindMin(MyArray)}");
System.Console.WriteLine($"Максимальный элемент = {FindMax(MyArray)}");
Double MinFromMax = FindMax(MyArray) - FindMin(MyArray);
System.Console.WriteLine($"Разница максимального и минимального элементов = {MinFromMax}");
// int result = CountSum(MyArray);
// System.Console.WriteLine($"Сумма всех нечетных чисел массива = {result}");
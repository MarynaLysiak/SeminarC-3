
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите числа через пробел: ");
// Разбивает строку на инт элементы, введенные через пробел
int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse); 

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

System.Console.WriteLine($"В массиве {CountPositive(arr)} положительных числа");

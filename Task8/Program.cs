// Напишите программу, которая выводит массив с нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

void PrintArray(int[] array) // функция вывода массива с целочисленными элементами 
{
    int count = array.Length;
    for (int i = 0; i <= count; i++)
    {
       System.Console.WriteLine($"{array[i]}"); 
    }
}

int[] FillArray(int size) // функция заполнения массива рандомными элементами
{
    int[] arrN = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrN[i] = new Random().Next(0, 2); // класс Random - генерация случайных чисел. Next - 
    }
    return arrN;
}

int[] myArray = FillArray(5); // сначала вызываем функцию для заполнения массива
PrintArray(myArray); // вызов функции для вывода массива, который заполнили выше.


// /Создание объекта для генерации чисел
// Random rnd = new Random();
 
// //Получить случайное число (в диапазоне от 0 до 10)
// int value = rnd.Next(0, 10);
 
// //Вывод числа в консоль
// Console.WriteLine(value); 



// void PrintArray(int[] array)
// {
// int count = array.Length;
// for (int i = 0; i < count; i++)
// {
// System.Console.Write($"{array[i]} ");
// }
// }

// int[] FillArray(int size)
// {
// int[] arrN = new int[size];
// for (int i = 0; i < size; i++)
// {
// arrN[i] = new Random().Next(0, 2);
// }
// return arrN;
// }

// int[] myArray = FillArray(8);
// PrintArray(myArray);




// автозаполнение массива
// void GetArray(int[] arr)
// {
// var rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rand.Next(0, 2);
// }
// }

// void PrintArray(int[] arr)
// {
// System.Console.WriteLine("["+string.Join(", ", arr)+"]");
// }

// int[] myArray = new int[8];
// GetArray(myArray);
// PrintArray(myArray);
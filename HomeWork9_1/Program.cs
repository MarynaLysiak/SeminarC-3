// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumM = GetNumbers("Введите число M начало промежутка: ");
int NumN = GetNumbers("Введите число N конец промежутка: ");
System.Console.WriteLine(GetSum(NumM, NumN));

int GetNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int GetSum(int m, int n)
{
    if (n == m) 
    {
    return m;
    }  
    return GetSum(m, n-1) + n;
}




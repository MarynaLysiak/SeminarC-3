// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int NumM = GetNumbers("Введите число M: ");
int NumN = GetNumbers("Введите число N: ");
System.Console.WriteLine(Akkerman(NumM, NumN));

int GetNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return  n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0);
    {
        return Akkerman((m-1), Akkerman(m, n - 1));
    }
}
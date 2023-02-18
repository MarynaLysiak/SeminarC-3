// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetCoordinates(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(System.Console.ReadLine());
}

double b1 = GetCoordinates("Введите координату b1: ");
double k1 = GetCoordinates("Введите координату k1: ");
double b2 = GetCoordinates("Введите координату b2: ");
double k2 = GetCoordinates("Введите координату k2: ");

double x = (b2-b1)/(k1-k2);
double y = k1*x+ b1;


System.Console.WriteLine($"Две линии пересекаются в точке: ({Math.Round(x, 3)}, {Math.Round(y, 3)})");
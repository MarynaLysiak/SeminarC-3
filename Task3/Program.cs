// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Математические функции: Math.Pow(98, 2) - 98 возводим во вторую степень
//  Math.Sqrt(25) - вычисление квадратного корня,
// Округление числа Math.Round(a,3) - округлить число а до 3 точек после запятой
// Формула для нахождения расстояния между 2 точками: ((х2-х1)ˆ2+(y2-y1)ˆ2)ˆ1/2 (корень квадратный из суммы)

int InputNumber(string stroka)
{
    System.Console.Write(stroka);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату х1: ");
int y1 = InputNumber("Введите координату у1: ");
int x2 = InputNumber("Введите координату х1: ");
int y2 = InputNumber("Введите координату у1: ");

double distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2)),3);
System.Console.WriteLine(distance);
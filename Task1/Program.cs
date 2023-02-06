//  Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// Функция, с помощью которой можно сократить строки описания ввода переменных.

int InputNumber(string stroka)
{
    System.Console.Write(stroka);
    return Convert.ToInt32(Console.ReadLine());
}

int x = InputNumber("Введите координату х: ");
int y = InputNumber("Введите координату у: ");

// System.Console.Write("Введите координату X: "); 
// int x = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());


void FindQuarter (int a, int b)
{
if (a > 0 && b > 0)
{
    System.Console.WriteLine("Точка с такими координатами попадает в 1 четверть");
}
else if (a > 0 && b < 0)
{
    System.Console.WriteLine("Точка с такими координатами попадает во 2 четверть");
}
else if (a < 0 && b > 0)
{
    System.Console.WriteLine("Точка с такими координатами попадает в 4 четверть");
}
else if (a < 0 && b < 0)
{
    System.Console.WriteLine("Точка с такими координатами попадает в 3 четверть");
}
else
{
    System.Console.WriteLine("Точка соответствует началу координат");
}
}

FindQuarter (x, y);
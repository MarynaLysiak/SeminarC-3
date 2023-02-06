// апишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


System.Console.WriteLine("Введите номер четверти: ");
int NumberQuarter = Convert.ToInt32(Console.ReadLine());


if (NumberQuarter == 1)
{
    System.Console.Write("x > 0, y > 0");
}
else if (NumberQuarter == 2)
{
    System.Console.WriteLine("x < 0, y > 0");
}
else if (NumberQuarter == 3)
{
    System.Console.WriteLine("x < 0, y < 0");
}
else if (NumberQuarter == 4)
{
    System.Console.WriteLine("x > 0, y < 0");
}
else
{
    System.Console.WriteLine("Такой четверти нет");
}
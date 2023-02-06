// апишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


System.Console.WriteLine("Введите номер четверти: ");
int NumberQuarter = Convert.ToInt32(Console.ReadLine());

string [] array = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};


if (NumberQuarter == 1)
{
    System.Console.Write(array[0]);
}
else if (NumberQuarter == 2)
{
    System.Console.WriteLine(array[1]);
}
else if (NumberQuarter == 3)
{
    System.Console.WriteLine(array[2]);
}
else if (NumberQuarter == 4)
{
    System.Console.WriteLine(array[3]);
}
else
{
    System.Console.WriteLine("Такой четверти нет");
}
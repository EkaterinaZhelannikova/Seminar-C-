//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Clear();
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

if ((num < 1) || (num > 4))
{
    Console.Write("Существует только четыре четверти"); 
}
else if (num == 1)
{
    Console.Write("x > 0, y > 0");
}
else if (num == 2)
{
    Console.Write("x < 0, y > 0");
}
else if (num == 3)
{
    Console.Write("x < 0, y < 0");
}
else
{
    Console.Write("x > 0, y < 0");
}
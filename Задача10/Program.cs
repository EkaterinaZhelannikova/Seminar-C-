﻿//Напшите программу, которая принимает на вход координаты точки (X и Y),
//причем X не равно 0 и Y не равно 0 и выдыет номер четверти, в которой
//находится эта точка.

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0) {
    if (Y > 0) 
    {
        Console.WriteLine("1");
    }
    else
    {
        Console.WriteLine("4");
    }
}
else
{
    if(Y > 0)
    {
        Console.WriteLine("2");
    }
    else
    {
        Console.WriteLine("3");
    }
}
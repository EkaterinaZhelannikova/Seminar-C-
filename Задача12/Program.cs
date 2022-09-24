//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве
// A (3, 6); B (2, 1) -> 5,09

Console.Clear();
Console.Write("Введите координату X для A: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для A: ");
int ya = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Х для B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для B: ");
int yb = int.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.Write($"длина отрезка = {d:f2}");
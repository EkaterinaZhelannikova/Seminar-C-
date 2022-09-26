//Напииште программу, которая принимает на вход число (N)
//и выдает таблицу квадратов чисел от 1 до N
//5 -> 1, 4, 5, 16, 25

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;

while(count <= n)
{
    Console.Write(Math.Pow(count, 2));
    if(count != n)
    {
        Console.Write(", ");
    }
    count++;
}
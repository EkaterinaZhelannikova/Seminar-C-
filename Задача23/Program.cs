//Напишите программу, которая принимает на вход число (А)
//и выдает сумму чисел от 1 до А. Использовать рекурсию
//7 -> 28

Console.Clear();

int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum: {RecSum(number)}");


int RecSum (int number)
{
    if (number > 1)
    {
        return number + RecSum(number - 1) ;
    }
    else
    {
        return 1;
    }
}
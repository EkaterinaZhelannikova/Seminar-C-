//Напишите программу, которая принимает на вход число и выдает
//количество цифр в числе. Использовате рекурсию
//456 -> 3

Console.Clear();

Console.Write($"Введите число: ");

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

int CountDigits(int num)
{
    if (num / 10 < 1) return 1;
    else return 1 + CountDigits(num / 10);
}
//Напишите программу, которая принимает на вход число и выдает
//количество цифр в числе. Использовате рекурсию
//456 -> 3

Console.Clear();

Console.Write($"Введите число: ");

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

int CountDigits(int number, int counter = 1)
{
    if (number / 10 == 0)
    {
        return counter;
    }
    else
    {
        return counter + CountDigits(number / 10);
    }
}
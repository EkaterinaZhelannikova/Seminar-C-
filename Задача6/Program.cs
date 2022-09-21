//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46

Console.Clear();

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.Write($"{firstDigit * 10 + thirdDigit}");

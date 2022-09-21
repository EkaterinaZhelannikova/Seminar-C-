//Напишите программу, которая принимает на вход два числа и проверяет,
//является ли одно число квадратом другого.
 
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else if(number2 == number1 * number1)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine("Числа НЕ являются квадратами друг друга");
}
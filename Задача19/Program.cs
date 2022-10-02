//Задайте массив из 12 элементов, заполненный случайными числами
//из промежутка [-9,9]. Напишите 2 функции:
//- найти сумму положительных чисел
//- найти сумму отрицательных чисел

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");

string input = Console.ReadLine()!;
int[] array = ParseToArray(input);

Console.WriteLine($"Положительная сумма: {PositivSum(array)}");
Console.WriteLine($"Отрицательная сумма: {NegativSum(array)}");

int[] ParseToArray (string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int PositivSum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += array[i];
    }
    return count;
}

int NegativSum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            count += array[i];
    }
    return count;
}

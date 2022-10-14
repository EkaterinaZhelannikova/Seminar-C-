//Задан массив, в котором хранится двоичное представление числа. Нужно вывести его десятичное представление
//{0,1,1,1,1} -> 15

Console.Clear();

int[] doubleNum = {0, 1, 1, 1, 1};
Array.Reverse(doubleNum);
double result = 0;
PrintArray(doubleNum);

for (int i = 0; i < doubleNum.Length; i++)
{
    result += Math.Pow(2, i) * doubleNum[i];
}
Console.WriteLine(result);

void PrintArray (int[] doubleNum)
{
    int count = doubleNum.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(doubleNum[i]);
        if (i == count - 1)
        {
            Console.Write("]");
        }
        else
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
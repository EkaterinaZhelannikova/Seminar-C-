//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
//4; массив [6,7,19,345,3] -> нет
//-3; массив [6,7,19,345,-3] -> да

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = CreateArray();
string result = String.Empty;
PrintArray(array);
FindNumber(array, num);
Console.Write(result);

int[] CreateArray()
{
    int[] array = {6, 7, 19, 345, 3};
    return array;
}

void PrintArray (int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
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

void FindNumber (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
       if(num == array[i])
       {
        result = $"Число {num} присутствует в массиве";
        break;
       }
       else
       {
        result = $"Числа {num} нет в массиве";
       }
    }
}
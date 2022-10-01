//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99] (с ошибкой)

Console.Clear();

int[] array = new int[12];
FillArray(array);
PrintArray(array);
int count = Elements(array);
Console.WriteLine($"Количество элементов в массиве от 10 до 99 равно {count}");

int Elements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99));
        {
            count++;
        }
    }
    return count;
}


void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 201);
    }
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

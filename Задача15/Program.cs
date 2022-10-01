//Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4,-8,8,2] -> [4,8,-8,-2]

Console.Clear();

int[] array = CreateArray();
PrintArray(array);
ReverArray(array);
PrintArray(array);

int[] CreateArray()
{
    int[] array = {-4, -8, 8, 2};
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

void ReverArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = -array[i];
    }
}
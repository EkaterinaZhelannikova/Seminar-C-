//Найдите произведение пар чисел в одномерном массиве. Парой считаем
//первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
//[1,2,3,4,5] -> [5,8,3]

Console.Clear();

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int[] newArray = Product(array);
PrintArray(newArray);

int[] Product(int[] array)
{
    int[] newArray;
    if (array.Length % 2 == 0)
    {
        newArray = new int [array.Length/2];
        for (int i = 0; i < array.Length/2; i++)
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
        }
    }
    else
    {
        newArray = new int [array.Length/2 + 1];
        for (int i = 0; i < array.Length/2 + 1; i++)
        {
            if (i == array.Length/2)
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i] = array[i] * array[array.Length - i - 1];
            }
        }
    }
    return newArray;
}

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 10);
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
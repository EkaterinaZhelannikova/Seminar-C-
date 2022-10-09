//Задайте двумерный массив. Найдите элементы, у которых оба индекса четные
//и замените эти элементы на их квадраты

Console.Clear();
 
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaceArray(array);
PrintArray(array);
 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
 
void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(1,10);
        }
    }
}

void ReplaceArray(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i+=2)
    {
        for (int j = 2; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }

    }
}
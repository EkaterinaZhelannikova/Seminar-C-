//Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали

Console.Clear();
 
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали {SumDiaArray(array)}");
 
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

int SumDiaArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i += 1)
    {
        for (int j = 0; j < array.GetLength(1); j += 1)
        {
            if (i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}


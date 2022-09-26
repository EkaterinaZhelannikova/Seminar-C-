//Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4,-8,8,2] -> [4,8,-8,-2]

Console.Clear();

int[] array = {-4, -8, 8, 2};
void Function (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i] * (-1)} ");
    }
}

Function(array);
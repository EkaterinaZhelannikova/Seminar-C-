//Напишите программу, число, создает массив данного размера, заполняет его нулями и единицами
//в случайном порядке и выводит в консоль.
// 8 -> [1,0,1,1,0,1,0,0]

Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
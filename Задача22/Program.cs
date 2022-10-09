//Напишите программу, которая перевернет одномерный массив (последний элемент
//будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
int[] newArray = Reverse(array);
Console.WriteLine(String.Join(", ", newArray));

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

int[] Reverse (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int count = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = count;
    }
    return array;
}
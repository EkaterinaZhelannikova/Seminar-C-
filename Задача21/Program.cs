//Напишите метод, который объединяет 2 массива в 1

Console.Clear();
Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] newArray = ParseToArray(firstArray, secondArray);
Console.WriteLine(String.Join(", ", newArray));

int[] ParseToArray(string str1, string str2)
{
    string str = str1 + ' ' + str2;
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

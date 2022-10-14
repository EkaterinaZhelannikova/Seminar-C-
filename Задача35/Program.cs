//Задан массив, в котором хранится двоичное представление числа. Нужно вывести его десятичное представление
//{0,1,1,1,1} -> 15

Console.Clear();

int[] doubleNum = {0, 1, 1, 1, 1};
Array.Reverse(doubleNum);
double result = 0;

for (int i = 0; i < doubleNum.Length; i++)
{
    result += Math.Pow(2, i) * doubleNum[i];
}
Console.WriteLine(result);

// int[] arrayData = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] arrayInfo = { 2, 3, 3, 1 };

// for (int i = 0; i < arrayInfo.Length; i++)
// {
//     int decNum = 0;
//     for (int j = 0; j < arrayInfo[i]; j++)
//     {
//         arrayData[j] = arrayData[j] * (int)Math.Pow(2, arrayData.Length - i - 1);
//         decNum += arrayData[i];
//     }
//     Console.Write($"{decNum} ");

// }


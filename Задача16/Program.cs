//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
//4; массив [6,7,19,345,3] -> нет
//-3; массив [6,7,19,345,-3] -> да

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = {6, 7, 19, 345, 3};
string result = String.Empty;
void Function (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       if(num == array[i])
       {
        result = "Да";
        break;
       }
       else
       {
        result = "Нет";
       }
    }
}
Function(array);

Console.Write(result);
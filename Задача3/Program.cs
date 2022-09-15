Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = -num;

while(count <= num)
{
    Console.Write($"{count} ");
    count++;
}
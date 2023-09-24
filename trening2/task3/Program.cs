// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int range = Start("Введите длину массива: ");
int num = Start("Введите число: ");

int[] FillArray(int range)
{
    Random rnd = new Random();
    int[] arr = new int[range];
    for(int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

int[] array = FillArray(range);

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0 ; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]} ]");
}

PrintArray(array);
Console.WriteLine();

bool Sravnenie(int number, int[] arr)
{
    bool result = false;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }
    return result;
}

Console.WriteLine(Sravnenie(num, array));
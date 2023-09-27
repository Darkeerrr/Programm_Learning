// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int number)
{
    int[] arr = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write($"{arr[arr.Length - 1]} ]");
}

int Result(int[] arr)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) result += 1;

    }
    return result;
}

int num = Start("Введите длинну массива: ");
int[] arr = FillArray(num);
PrintArray(arr);
Console.WriteLine();
int res = Result(arr);
Console.Write($"Колличество чётных чисел: {res}");
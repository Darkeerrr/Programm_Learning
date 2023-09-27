// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int number)
{
    int[] arr = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
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

int SummDigit(int[] arr)
{
    int sum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}

int num = Start("Введите длинну массива: ");
int[] arr = FillArray(num);
PrintArray(arr);
int sum = SummDigit(arr);
Console.WriteLine();
Console.WriteLine(sum);
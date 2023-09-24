//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Start(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int num = Start("Введите число: ");

int[] FillArray(int number)
{
    Random rnd = new Random();
    int[] arr = new int[number];
    for(int i = 0; i < number; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write($"{arr[arr.Length - 1]} ]");
}

int[] arr = FillArray(num);
PrintArray(arr);
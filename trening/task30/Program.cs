// Напишите программу которая выводить массив с 8 элементами заполненными нулями и единицами в случайном порядке

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
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] arr = FillArray(num);
PrintArray(arr);
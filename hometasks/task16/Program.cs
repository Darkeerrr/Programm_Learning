// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[] FillArray(int number)
{
    double[] arr = new double[number];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (10 - 1) + 1, 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write($"{arr[arr.Length - 1]} ]");
}

double Raznitsa(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double result = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    result = max - min;
    return result;
}

int num = Start("Введите длинну масива: ");
double[] arr = FillArray(num);
PrintArray(arr);
Console.WriteLine();
double res = Raznitsa(arr);
Console.WriteLine(res);
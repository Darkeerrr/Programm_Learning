// Программа принимает на вход число а и выдаёт сумму чисел от одного до А

int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number + 1;
}

void PrintArray(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] FillArray(int number)
{
    int[] arr = new int [number];
    for (int i = 1; i < number; i++)
    {
        arr[i] = i;
    }
    return arr;
}
int Summ(int[] arr)
{
    int sum = arr.Sum();
    Console.WriteLine(sum);
    return sum;
}
int A = Start("Введите число: ");
int[] arrA = FillArray(A);
PrintArray(arrA);
Console.WriteLine();
int sum = Summ(arrA);


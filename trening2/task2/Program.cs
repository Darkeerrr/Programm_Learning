// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int length = Start("Введите длинну массива: ");

int[] FillArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for(int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 10);
    }
    return arr;
}

int[] arr = FillArray(length);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}

PrintArray(arr);

void Opposite(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= (-1);
    }
}

Opposite(arr);
Console.WriteLine();
PrintArray(arr);
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number ;
}

int[] Fibs(int num)
{
    int[] fibs = new int[num];
    fibs[0] = 0;
    fibs[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibs[i] = fibs[i - 1] + fibs[i - 2];
    }
    return fibs;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write($"{arr[arr.Length - 1]} ]");
}

int num = Start("Введите число: ");
int[] array = Fibs(num);
// Console.WriteLine(string.Join(", ", array));
PrintArray(array);


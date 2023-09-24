//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]
// Найдите сумму отрицательных и положительных элементов массива.

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rand.Next(min,max + 1);
    }

    return result;
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

int size = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("Введите максимальное значение диапазона: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int[] sums = GetSums(array);
Console.WriteLine($"Сумма положительных чисел равно {sums[0]}, сумма отрицательных {sums[1]}");

int[] GetSums(int[] inArray)
{
    int[] res = new int[2];
    foreach (int el in array) // каждое значение из массива записывается в el
    {
        if(el > 0) res[0] +=el;
        else res[1] +=el;
    }
    return res;
}
// Console.WriteLine($"Сумма положительных чисел равно {positiveSum}, сумма отрицательных {negativeSum}");
// Console.WriteLine(string.Join(" ", array));
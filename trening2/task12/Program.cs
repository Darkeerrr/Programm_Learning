// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = Start("Введите высоту массива: ");
int columns = Start("Введите ширину массива: ");

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] arr = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // row
    {
        for (int j = 0; j < array.GetLength(1); j++) // column
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(rows, columns, 10, 100);
PrintArray(array);
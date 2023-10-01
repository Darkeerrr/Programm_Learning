// Задайте двумерный массив.
// Найти сумму элементов
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int row, int column)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i,j] = i + j;
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfAgonal(int[,] array)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                result += array[i,j];
            }
        }
    }
    return result;
}

int row = Start("Введите кол-во строк: ");
int column = Start("Введите кол-во столбцов: ");
int[,] arr = GetArray(row, column);
PrintArray(arr);
int res = SumOfAgonal(arr);
Console.WriteLine(res);
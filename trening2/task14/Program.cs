// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void TransformArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if((i + 1)%2 == 0 && (j + 1)%2 == 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
}

int row = Start("Введите кол-во строк в массиве: ");
int column = Start("Введите кол-во столбцов в массиве: ");
int[,] arr = GetArray(row, column);
PrintArray(arr);
TransformArray(arr);
Console.WriteLine();
PrintArray(arr);
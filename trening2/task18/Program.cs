// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int row = Start("Введите кол-во строк в массиве: ");
int column = Start("Введите кол-во столбцов в массиве: ");

int[,] FillArray(int row, int column)
{
    int[,] arr = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

int[,] array = FillArray(row, column);
PrintArray(array);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("| ");
        for( int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}

bool Change(int[,] arr)
{
    if ( arr.GetLength(0) == arr.GetLength(1)) return true;
    else return false;
}

int[,] ReverseRowColumn(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
    return newMatrix;
}

if (Change(array))
{
    ReverseRowColumn(array);
    Console.WriteLine();
    PrintArray(array);
}
else Console.WriteLine("Массив построить нельзя!");
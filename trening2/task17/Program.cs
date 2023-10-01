// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void ReverseRow(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

ReverseRow(array);
Console.WriteLine();
PrintArray(array);
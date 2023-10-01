// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillMatrix(int row, int column)
{
    int[,] arr = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for( int j = 0; j < column; j++)
        {
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

int[,] FillMatrixRes(int row, int column)
{
    int[,] arr = new int[row, column];
    for(int i = 0; i < row; i++)
    {
        for( int j = 0; j < column; j++)
        {
            arr[i,j] = 0;
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for(int i = 0; i< arr.GetLength(0); i++)
    {
        Console.Write("| ");
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}

int row = Start("Введите кол-во строк в массиве: ");
int column = Start("Введите кол-во столбцов в массиве: ");
int[,] arr1 = FillMatrix(row, column);
int[,] arr2 = FillMatrix(row, column);
int[,] resultArray = FillMatrixRes(row, column);
// int[,] resultArray = FillMatrix(row, column);
PrintMatrix(arr1);
Console.WriteLine();
PrintMatrix(arr2);
Console.WriteLine();
PrintMatrix(resultArray);

if (arr1.GetLength(0) != arr2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        for (int k = 0; k < arr1.GetLength(1); k++)
        {
            resultArray[i, j] += arr1[i, k] * arr2[k, j];
        }
    }
}
Console.WriteLine();
PrintMatrix(resultArray);

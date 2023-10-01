// Создать 2 массива и умножить один на другой

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
int[,] array2 = FillArray(row, column);

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

PrintArray(array);
Console.WriteLine();
PrintArray(array2);

int[,] Umnoj(int[,] arr, int[,] arr2)
{
    int[,] res = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res[i,j] = arr[i,j] * arr2[i,j];
        }
    }
    return res;
}

int[,] res = Umnoj(array, array2);
Console.WriteLine();
PrintArray(res);
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int row = Start("Введите кол-во строк: ");
int column = Start("Введите кол-во столбцов: ");
int[,] arr = FillArray(row, column);
PrintArray(arr);
Console.WriteLine();
int[,] arr2 = SortToLower(arr);
PrintArray (arr2);

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillArray(int num1, int num2)
{
    int[,] arr = new int[num1, num2];
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}

int[,] SortToLower(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}
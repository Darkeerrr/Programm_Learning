// Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}

int SummLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

// int SummLine(int[,] arr)
// {
//     int minres = 0;
//     int res = 0;
//     int minsumline = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             res += arr[i, j];
//         }
//         if (minres > res)
//         {
//             minres = res;
//             minsumline = i;
//         }
//         res = 0;
//     }
//     Console.WriteLine();
//     return minsumline;
// }

int row = Start("Введите число строк: ");
int column = Start("Введите число столбцов: ");
int[,] arr = FillMatrix(row, column);
PrintMatrix(arr);
int minSumLine = 0;
int sumLine = SummLineElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumLine = SummLineElements(arr, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"{minSumLine+1} - строка с наименьшей суммой ({sumLine}) элементов ");
// int minsumline = SummLine(arr);
// int minres = SummElements(arr);
// Console.WriteLine($"Строка: {minsumline} имеет наименьшую сумму {minres}");
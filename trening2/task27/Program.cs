//  Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillArray(int row, int column, int k)
{
    int[,] arr = new int[row, column];
    int count = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] += count;
            count += k; 
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}

// void Schet(int[,] arr)
// {
//     double result = 0;
//     int count = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             result += arr[i, j];
//             count = i + 1;
//         }
//         Console.Write((result / count) + "; ");
//         result = 0;
//         count = 0;
//     }
// }
double [] FindAverageInColumns (int [,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    result[0] = 0;
    int z = 0;
    double count = 0;
    for ( int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result[z] += arr[i,j];
            count ++;
        }
        result[z] = result[z] / count;
        
        count = 0;
        z++;
    }
      return result;
}

void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("Вот ваши средние значения!!!! Подавитесь!!!");
      for (int i = 0; i < list.Length; i++)
      {
        Console.Write(string.Format("{0:F2}",list[i]) + "\t");
      }

    }

int row = Start("Введите кол-во строк: ");
int column = Start("Введите кол-во столбцов: ");
int k = 2;
int[,] arr = FillArray(row, column, k);
PrintArray(arr);
double[] arr1 = FindAverageInColumns(arr);
PrintListAvr(arr1);
// Schet(arr);
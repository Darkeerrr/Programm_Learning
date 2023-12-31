﻿// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }


    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] arr = new int[n,m];
      int count = 1;
        for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i,j] += count;
          count += k;
        }
    }
    return arr;

    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
      int[] array = new int[matrix.Length];
    int count = 0;
      if (matrix.GetLength(0) > rowPosition && matrix.GetLength(1) > columnPosition)
      {
    for (int i = 0; i < rowPosition; i++)
    {
        for (int j = 0; j < columnPosition; j++)
        {
            array[count] = matrix[i,j];
          count++;
        }
      }
      }
//       else Console.WriteLine($"There is no such index");
    return array;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
      int n = (X)*(Y);
      if (results.Length < n)
        {
        Console.WriteLine($"There is no such index");
        }
      else
      {
        Console.WriteLine($"The number in [{X}, {Y}] is {results[n -1]}");
      }
    }

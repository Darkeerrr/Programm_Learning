﻿// Напишите программу, которая на вход принимает число и выдает его квадрат
// (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
// Пример конкотинации это объединение текстовой строки и вычислений
// Логика последовательности как в математике
Console.WriteLine("Квадрат числа = " + number * number);
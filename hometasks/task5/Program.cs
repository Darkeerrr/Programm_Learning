// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа

using System.Globalization;

Console.WriteLine("Введите трёхзначное число: ");
int digit = int.Parse(Console.ReadLine()!);
if(digit < 100)
{
    Console.WriteLine("Число двухзначное!");
}
int num = digit / 10;
int result = num % 10;
Console.WriteLine($"Ответ: {result}");
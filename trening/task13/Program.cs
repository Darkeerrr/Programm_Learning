//Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine(num);
int num1 = new Random().Next(10, 100);
Console.WriteLine(num);
int num2 = new Random().Next(10, 100);
Console.WriteLine(num);
FindMaxDigit(num);
FindMaxDigit(num1);
FindMaxDigit(num2);

void FindMaxDigit(int number)
{
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine($"Первое число: {firstDigit}, Второе число: {secondDigit}");
if(firstDigit > secondDigit)
{
    Console.WriteLine($"Первое число больше: {firstDigit}");
}
else if(firstDigit == secondDigit)
{
    Console.WriteLine("Цифры равны");
}
else
{
    Console.WriteLine($"Второе число больше: {secondDigit}");
}
}
// Напишите программу, которая выводит случайное трёхзначное число и удалаяет вторую цифру этого числа
// Например:
// 456 -> 46
// 782 -> 72

int num = new Random().Next(100, 1000);
Console.WriteLine($"Наше число: {num}");
int num1 = new Random().Next(100, 1000);
Console.WriteLine($"Наше число: {num1}");
int num2 = new Random().Next(100, 1000);
Console.WriteLine($"Наше число: {num2}");
Create(num);
Create(num1);
Create(num2);

void Create(int number)
{
int digit1 = number / 100;
Console.Write($"Первая цифра: {digit1}, ");

int digit2 = number % 100;
int digit22 = digit2 / 10;
Console.Write($"Вторая цифра: {digit22}, ");

int digit3 = number % 10;
Console.Write($"Третья цифра: {digit3} ");

string newarg = digit1.ToString() + digit3.ToString();
Console.WriteLine($"Полученное число из 1-го и 3-го эллемента числа: {newarg}");
}
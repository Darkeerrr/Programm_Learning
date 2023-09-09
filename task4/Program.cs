// Я вляится ли число тем из которого преобразуется квадрат этого числа
// Например:
// 2 = 4 true
// 6 = 24 false
// -3 = 9 true

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите квадрат числа: ");
int b = int.Parse(Console.ReadLine());
if (b == a * a)
{
    Console.WriteLine("Да, верно!");
}
else
{
    Console.WriteLine("Неверно!");
}
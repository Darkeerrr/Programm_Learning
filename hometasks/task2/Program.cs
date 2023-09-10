// Программа принимает на вход три числа и выдаёт максимальное
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third = int.Parse(Console.ReadLine());
if (first > second)
{
    if (first > third)
    {
        Console.WriteLine("Первое число максимальное: " + first);
    }
}
if (second > first)
{
    if (second > third)
    {
        Console.WriteLine("Второе число максимальное: " + second);
    }
}
if (third > first)
{
    if (third > second)
    {
        Console.WriteLine("Третье число максимальное: " + third);
    }
}
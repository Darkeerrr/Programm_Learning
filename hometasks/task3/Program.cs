// Программа принимает число и проверяет является ли число чётным
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if ((a % 2) > 0)
{
    Console.WriteLine("Число нечётное: " + a);
}
else
{
    Console.WriteLine("Число чётное: " + a);
}
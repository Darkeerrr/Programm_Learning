//Напишите программу которая на входе принимает 2 числа и проверяет их кратность, если число 2 не кратно числу 1 то выводит остаток от деления

Console.WriteLine("Введите первое число: ");
int digit1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int digit2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int digit3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int digit4 = int.Parse(Console.ReadLine());

void multiply(int first, int second)
{
if (first % second != 0)
{
    int raz = first % second;
    Console.WriteLine($"Числа не кратны друг другу, остаток равен: {raz}");
}
else
{
    Console.WriteLine("Числа кратны друг другу!");
}
}
multiply (digit1, digit2);
multiply (digit3, digit4);
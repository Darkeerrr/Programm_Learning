// Напишите программу которая принимает на вход два числа и проверяет является ли число квадратом другого
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите его квадрат: ");
int num2 = int.Parse(Console.ReadLine());

void Proverka(int first, int second)
{
    if (first * first == second)
    {
        Console.WriteLine("Второе число квадрат первого!");
    }
    else
    {
        Console.WriteLine("Не обманывай! Второе число не квадрат первого!");
    }
}
Proverka(num1,num2);
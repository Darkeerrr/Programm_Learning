// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Schet(int num)
{
    if (num == 0) return;
    else
    {
        Console.Write(num + " ");
        Schet(num - 1);
    }
}

int num = Start("Введите число: ");
Schet(num);
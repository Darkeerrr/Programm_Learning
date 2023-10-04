// Задайте значение N
// Напишите програму, которая выведет все натуральные числа в промежутке
// от 1 до N

int Start (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// int DigitPrint(int number)
// {
//     if (number == 1) return 1;
//     else return int.Parse(DigitPrint(number - 1) + $"{number} ");
// }

void DigitPrint(int number)
{
    if (number == 0) return;
    else
    {
        DigitPrint(number - 1);
        Console.Write(number + " ");
    }
}

int num = Start("Введите число: ");
// Console.WriteLine(DigitPrint(5));
DigitPrint(num);
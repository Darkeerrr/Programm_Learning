//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Start(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int num = Start("Введите число: ");

int Summ(int number)
{
    int result = 0;
    while( number > 0 )
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine($"Сумма всех цифр в числе {num} равна {Summ(num)}");
// Напишите программу которая принимает на вход пятизначное число и проверяет является ли оно полиндромом
// 14212 -> нет
// 23432 -> нет
// 12821 -> да

int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int num = Start("Введите пятизначное число: ");
Console.WriteLine(Sravnenie(num));

bool Sravnenie(int num)
{
    if (num > 100000 && num < 10000)
    {
        Console.WriteLine("Число не пятизначное!");
        return false;
    }
    else if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
    {
        Console.WriteLine("Это полиндром!");
        return true;
    }
    else
    {
        Console.WriteLine("Это не полиндром!");
        return false;
    }
}


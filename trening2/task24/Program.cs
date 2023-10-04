// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SummOfNum(int num)
{
    if (num == 0) return num;
    else return num % 10 + SummOfNum(num / 10); 
}

int n = Start("Input number: ");
Console.WriteLine(SummOfNum(n));
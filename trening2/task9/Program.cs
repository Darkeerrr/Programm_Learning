// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine(Binare(45));
Console.WriteLine(Binare2(45));

int Binare(int num)
{
    int binare = 0;
    int count = 1;
    while ( num >= 1)
    {
        binare = binare + num % 2 * count;
        count *= 10;
        num /= 2;
    }
    return binare;
}

string Binare2(int number)
{
    string binare = string.Empty;
    while(number >= 1)
    {
        binare = number % 2 + binare;
        number /=2;
    }
    return binare;
}

string str = Convert.ToString(13, 2);
Console.WriteLine(str);
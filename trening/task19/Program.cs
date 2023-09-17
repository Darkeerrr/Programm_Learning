// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y)

int Start (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string Sravnenie(int c)
{
    string result = string.Empty;
    if ( c == 1 )
    {
        result ="Диапазон от x > 0 и y > 0";
    }
    else if ( c == 2 )
    {
        result ="Диапазон от x < 0 и y > 0";
    }
    else if ( c == 3 )
    {
        result ="Диапазон от x < 0 и y < 0";
    }
    else if ( c == 4 )
    {
        result ="Диапазон от x > 0 и y < 0";
    }
    else
    {
        result ="Error";
    }
    return result;
}
int chet = Start("Введите четверть: ");
Console.WriteLine(Sravnenie(chet));
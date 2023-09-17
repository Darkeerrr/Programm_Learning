// Написать программу, которая принимает на вход координаты точки (X и Y)
// причём X != 0 и Y != 0 и выдаёт номер четверти плоскости в которой находится эта точка

int WorkWithUser(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string FinderQuarter(int X, int Y)
{
    string result = string.Empty;
    if (X > 0 && Y > 0)
{
    result ="Первая четверть";
}
else if (X < 0 && Y > 0)
{
    result ="Вторая четверть";
}
else if (X < 0 & Y < 0)
{
    result ="Третья четверть";
}
else if (X > 0 && Y < 0)
{
    result ="Четвёртая четверть";
}
else
{
    result ="Ошибка";
}
return result;
}

int x = WorkWithUser("Введите X: ");
int y = WorkWithUser("Введите Y: ");
Console.WriteLine(FinderQuarter(x,y));
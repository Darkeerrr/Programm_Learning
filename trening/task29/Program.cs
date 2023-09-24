// Программа принимает на вход число а на выходе выдаёт кол-во цифр в числе
// 2 => 1
// 100 => 3

int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int num = Start("Введите число: ");

int Schet(int schet)
{
    for(int i = 1; schet > 0; i++ )
    {
        schet /= 10;
        if (schet/1 == 0)
        {
            schet = i;
            break;  
        }
    } 
    return schet;
}

Console.WriteLine($"Колличество цифр в числе равно: {Schet(num)}");
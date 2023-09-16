// Напишите программу которая принимает на вход цифру являющееся днём недели и проверяет является ли день выходным

int Start (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Start("Введите день недели: ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        {
            Console.WriteLine("Рабочий день!");
        }
    }
}
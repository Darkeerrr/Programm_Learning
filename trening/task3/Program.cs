// Задача номер 3. Напишите программу которая будет выдовать день недели по заданному номеру
// Например:
// 1 = Понедельник
// 3 = Среда
Console.WriteLine("Напишите номер недели: ");
string day = Console.ReadLine();
if (Convert.ToInt32(day) == 1)
{
    Console.WriteLine("Понедельник");
}
if (Convert.ToInt32(day) == 2)
{
    Console.WriteLine("Вторник");
}
if (Convert.ToInt32(day) == 3)
{
    Console.WriteLine("Среда");
}
if (Convert.ToInt32(day) == 4)
{
    Console.WriteLine("Четверг");
}
if (Convert.ToInt32(day) == 5)
{
    Console.WriteLine("Пятница");
}
if (Convert.ToInt32(day) == 6)
{
    Console.WriteLine("Субота");
}
if (Convert.ToInt32(day) == 7)
{
    Console.WriteLine("Воскресенье");
}
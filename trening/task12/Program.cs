//Есть игрок, он умирает в игре, на каждую 5 смерть он задаёт себе вопрос, стоит ли ливнуть, написать программу, по которая выдаст на какой смерти ливнёт игрок
using System.ComponentModel;

Console.WriteLine("Введите имя игрока: ");
string igrok = Console.ReadLine();
Random rnd = new Random();
int smert = 1; // счётчик смертей
int a = 0; // каждые 5 смертей идёт проверка на выход из игры
for (int shans = 0; smert < 100;smert++)
{
    Console.WriteLine($"Блин {igrok} умер: {smert}");
    a = smert % 5;
    if (a <= 0)
    {
     shans = rnd.Next(0, 10);
     Console.WriteLine(shans);
     if (shans > 5)
     {
        Console.WriteLine($"{igrok} покинул игру и нафидел: " + smert + "раз");
        break;
     }
     else
     {
        Console.WriteLine($"Менталка стабильна {igrok} продолжил игру: " + smert + "раз умер");
     } 
    }
}
Console.WriteLine("Трон упал GG: " + smert);
// Напишите программу которая принимает на вход число которое должно быть одновременно кратно 7 и 23

// Random rnd = new Random();
// int digit = rnd.Next(1, 200);
// Console.WriteLine($"Новое число: {digit}");
// if (digit % 7 > 0 && digit % 23 > 0)
// {
//     do
//     {
//         digit = rnd.Next(1, 200);
//         Console.WriteLine($"Новое число: {digit}");
//     } while (digit % 7 > 0 && digit % 23 > 0);
// }
// else
// {
//     Console.WriteLine("Кратны!");
// }
// ПОМОГИТЕ НЕ ПОНИМАЮ!!!

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
void Multiply(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
       Console.WriteLine("Да"); 
    }
    else
    {
        Console.WriteLine("Нет!");
    }
}
Multiply(number);
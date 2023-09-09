// Напишите программу которая на вход принимает трёхзначное число а на выход выдаёт последнюю цифру этого числа
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = n % 10;
Console.WriteLine(i);
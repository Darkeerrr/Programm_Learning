// Напишите программу которая вводит число и показывает промежуток от -n до n
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = -n; i <= n; i++)
{
    Console.Write(i + " ");
}
// Программа принимает на входе число N и выдаёт на выходе все чётные числа от 1 до N
using System.Globalization;

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for (int i = 2;i <= num;i++)
{
   if ((i % 2 == 0 && i == num) || (i%2 == 0 && i + 1 == num))
   {
    Console.Write(i);
   }
   else if (i % 2 == 0)
   {
    Console.Write(i + ",");
   }
}

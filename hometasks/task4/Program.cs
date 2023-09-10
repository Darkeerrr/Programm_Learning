// Программа принимает на входе число N и выдаёт на выходе все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1;i <= N;i++)
{
    int b = i%2;
   if (b <= 0)
   {
    Console.Write(" " + i);
   }
}

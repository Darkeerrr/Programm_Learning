// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SummRange(int M, int N)
{
    if (N == M) return M;
    else
    {
        return SummRange(M, N - 1) + N;
    }
}

int M = Start("Введите начало отрезка: ");
int N = Start("Введите конец отрезка: ");
Console.WriteLine(SummRange(M,N));
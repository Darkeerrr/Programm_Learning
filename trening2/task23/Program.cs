// Задайте значения M и N
// Напишите программу которая выведет все натуральные числа
// в промежутке от M до N

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string Range1(int M, int N)
{
    if (M <= N) return ( $"{M} " + Range1(M + 1, N));
    else return string.Empty;
}

void GenerateNumbers(int start, int end)
{
if (start > end)
{
return;
}

Console.Write(start + ", ");

GenerateNumbers(start + 1, end);
}

int M = Start("Input number M: ");
int N = Start("Input number N: ");
 Console.WriteLine(Range1(M,N));
 GenerateNumbers(M,N);


// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] FillArray(int m, int n)
{
    double[,] arr = new double[m , n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for ( int j = 0; j< arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(rnd.NextDouble() * (10 + 10) + (-10), 1);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for( int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.Write(" |");
        Console.WriteLine();
    }
}

int m = Start("Введите m: ");
int n = Start("Введите n: ");
double[,] arr = FillArray(m,n);
PrintArray(arr);
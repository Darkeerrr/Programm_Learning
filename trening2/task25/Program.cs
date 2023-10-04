// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int Start(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Multiply(int a, int b)
{
    if (b == 0) return 1;
    else
    {
        return a * Multiply(a, b - 1);
    }
}

int a = Start("Введите число: ");
int b = Start("Введите степень числа: ");
Console.WriteLine(Multiply(a,b));
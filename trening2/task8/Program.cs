// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool Triangle(int a, int b, int c)
{
    bool result = false;
    if (a < (b + c) && b < (a + c) && c < (b + a)) result = true;
    return result;
}

int a = Start("Введите длину стороны a: ");
int b = Start("Введите длину стороны b: ");
int c = Start("Введите длину стороны c: ");
if(Triangle(a, b, c)) Console.WriteLine("Существует!");
else Console.WriteLine("Не существует");
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Start(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int first = Start("Введите 1 число: ");
int second = Start("Введите 2 число: ");

int Umnoj(int num1, int num2)
{
     int result = 2;
    for(int i = 2; i <= num2; i++)
    {
        result *= num1;
        Console.WriteLine(result);
        if (i == num2)
        {
            num1 = result;
        }
    }
    return num1;
}

Console.WriteLine($"Число {first} в степени {second} равно {Umnoj(first, second)}");
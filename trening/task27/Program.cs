// Произведение чисел от 1 до N


int Start(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;    
}

int num = Start("Введите число: ");

double Factorial(int number)
{
    if (number == 1) return 1;
    else return number * Factorial(number - 1);
}

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] Start(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    string[] symb = str.Split(", ");
    return symb;
}

int[] DigitOfString(string[] symbs)
{
    int[] digits = new int[symbs.Length];
    for(int i = 0; i < digits.Length; i++)
    {
        digits[i] = int.Parse(symbs[i]);
    }
    return digits;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}

int CountPositive(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res++;
    }
    return res;
}

string[] array = Start("Введите числа через запятую: ");
int[] collection = DigitOfString(array);
Console.WriteLine();
PrintArray(collection);
Console.WriteLine();
Console.WriteLine(CountPositive(collection));
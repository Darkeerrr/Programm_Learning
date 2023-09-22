// задать кубический массив чисел
int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int[] Kvadrat(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}
void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int num = Start("Введите длинну массива: ");
int[] arr = Kvadrat(num);
Print(arr);
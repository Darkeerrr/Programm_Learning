// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int size = 123;
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
int count = CountNumInArray(10, 99, numbers);
Console.WriteLine(count);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 124);
    }
}

int CountNumInArray(int min, int max, int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if(collection[i] >= min && collection[i] <= max) result += 1;
    }
    return result;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0 ; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"{array[array.Length - 1]} ] <= Масив");
}
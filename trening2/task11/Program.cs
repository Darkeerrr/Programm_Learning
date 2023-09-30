// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] collection = new int[] {1, 2, 3, 4, 5};
int[] copyCollection = GetArray(collection);
PrintArray(copyCollection);

int[] GetArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write($"{arr[arr.Length - 1]} ]");
}

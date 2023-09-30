// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем)
// [1 2 3 4 5] -> [5 4 3 2 1]


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        result[i] = rand.Next(minValue, maxValue);
    }
    return result;
}

void ReverseArray1(int[] arr)
{
    for ( int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] ReverseArray2(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for ( int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[arr.Length - 1 - i];
    }
    return newArray;
}

int[] array = GetArray(9, 0, 10);
Console.WriteLine(string.Join(", ", array));
ReverseArray1(array);
Console.WriteLine(string.Join(", ", array));
int[] reverseArray = ReverseArray2(array);
Console.WriteLine(string.Join(", ", reverseArray));
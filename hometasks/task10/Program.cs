// Напишите программу которая принимает на вход число N
// а на выход выдаёт таблицу кубов от 1 до N

int num = WorkWithUser("Введите число: ");
int[] arr = Square(num);
PrintArray(arr);



int WorkWithUser(string message)
{
Console.Write(message);
int number = int.Parse(Console.ReadLine());
return number;
}

int[] Square(int number)
{
int[] array = new int[number];
for (int i = 0; i < number; i++)
{
array[i] = (i + 1) * (i + 1) * (i + 1);
}
return array;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}
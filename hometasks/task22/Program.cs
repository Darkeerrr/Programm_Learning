// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Start(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,,] FillArray(int num1, int num2, int num3)
{
    int[,,] arr = new int[num1, num2, num3];
    Random rnd = new Random();
    for (int i = 0; i < num1; i++)
    {
        for (int j = 0; j < num2; j++)
        {
            for (int k = 0; k < num3; k++)
            {
                arr[i, j, k] = rnd.Next(1, 100);
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                        {
                            Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
                        }
                }
                Console.WriteLine();
        }
}

int i = Start("Введите i: ");
int j = Start("Введите j: ");
int k = Start("Введите k: ");
int[,,] arr = FillArray(i,j,k);
PrintArray(arr);
// На вход принимаются два числа и выводится максимальное
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Ввелите второе число: ");
int second = int.Parse(Console.ReadLine());
if (first > second)
{
    Console.WriteLine("Первое число больше: " + first);
}
if (second < first)
{
    Console.WriteLine("Второе число больше: " + second);
}
if (first == second)
{
    Console.WriteLine("Они равны: " + first);
}
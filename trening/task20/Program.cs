// Напишите программу которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве
// Пример:
// A(3,6); B(2,1) -> 5,89

int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int xa = Start("Ввдеите X1: ");
int ya = Start("Введите Y1: ");
int xb = Start("Ввдеите X2: ");
int yb = Start("Введите Y2: ");
Console.WriteLine(Distance(xa, ya, xb, yb));

double Distance(double xa, double ya, double xb, double yb)
{
    double distance = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
    return distance;
}
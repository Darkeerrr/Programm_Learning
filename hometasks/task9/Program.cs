// Посчитать расстояние между двумя точками в 3D пространстве
//A(3,6,8) B(2,1,-7) -> 15,84



int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int xa = Start("Ввдеите X1: ");
int ya = Start("Введите Y1: ");
int za = Start("Введите Z1: ");
int xb = Start("Ввдеите X2: ");
int yb = Start("Введите Y2: ");
int zb = Start("Введите Z2: ");
Console.WriteLine(Distance(xa, ya, za, xb, yb, zb));

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distance = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb)*(za - zb));
    return distance;
}
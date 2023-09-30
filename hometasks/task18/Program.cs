// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Start(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double b1 = Start("Введите b1:");
double k1 = Start("Введите k1:");
double b2 = Start("Введите b2:");
double k2 = Start("Введите k2:");

double[] Resolve(double b1, double k1, double b2, double k2)
{
    double[] resolve = new double[2];
    resolve[0] = (b2 - b1)/(k1 - k2);
    resolve[1] = k1 * resolve[0] + b1;
    return resolve;
}

double[] res = Resolve(b1,k1,b2,k2);
Console.WriteLine(string.Join(", ", res));
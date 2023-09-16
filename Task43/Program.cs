/*
43 Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/
/*
|y=k1*x+b1   |y-y=k1x+b1-k2x-b2    |0=k1x-k2x-b2+b1    |k2x-k1x=b1-b2    |x=(b1-b2)/(k2-k1)
|         => |                  => |                => |              => |
|y=k2*x+b2   |y=k2x+b2             |y=k2x+b2           |y=k2x+b2         |y=k2x+b2
*/
System.Console.WriteLine("Введите значения b1, k1, b2, k2");
double b1 = Convert.ToInt32(System.Console.ReadLine());
double k1 = Convert.ToInt32(System.Console.ReadLine());
double b2 = Convert.ToInt32(System.Console.ReadLine());
double k2 = Convert.ToInt32(System.Console.ReadLine());

if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;

    System.Console.WriteLine($"Точка пересечения прямых  {Math.Round(x, 2)}:{Math.Round(y, 2)}");
}
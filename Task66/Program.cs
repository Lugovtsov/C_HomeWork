/*
66.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbMN(int M, int N)
{

    if (M < N)
    {
        return M + SumNumbMN(M + 1, N);
    }
    return M;
}

System.Console.WriteLine("Введите два числа ");
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine(SumNumbMN(M, N));
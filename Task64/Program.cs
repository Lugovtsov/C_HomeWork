/*
64.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NumberN(int num)
{
    if(num < 0)
    num = num * -1; 
    if( num != 0)
    {
        System.Console.Write(num + " ");
        NumberN(num - 1);
    }
}
System.Console.WriteLine("Введите число");
int usernum = Convert.ToInt32(Console.ReadLine());
NumberN(usernum);
*/
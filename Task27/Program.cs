/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Function(int number)
{
    int summ = 0;
    while(number > 0)
    {
        summ = summ + number % 10;
        number = number / 10;
    }
    return summ;
}
Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Function(numberA));

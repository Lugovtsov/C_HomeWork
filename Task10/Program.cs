/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int number1 = number % 100; 
    int number2 = number1 / 10;
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Введено неверное значение ");
}
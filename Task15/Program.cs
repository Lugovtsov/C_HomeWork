/*
15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

System.Console.WriteLine("Введите число ");
int userDay = Convert.ToInt32(Console.ReadLine());

if(userDay > 5 && userDay < 8)
{
    System.Console.WriteLine("Выходной");
}
else if(userDay > 0 && userDay < 6)
{
    System.Console.WriteLine("Будний день ");
}
else
{
    System.Console.WriteLine("Нет такого дня недели ");
}
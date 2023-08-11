/*
13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

Console.WriteLine("Введите число ");
int userNamber = Convert.ToInt32(Console.ReadLine());

if(userNamber < 100)
{
    Console.WriteLine("Нет третьей цифры ");
}
else if(userNamber > 100)
{
    while(userNamber > 999)
        {
            userNamber = userNamber / 10;
        }
    int result = userNamber % 10;
    System.Console.WriteLine(result);

}
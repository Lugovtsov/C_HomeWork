/*
41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int[] GetUserArray()
{
    System.Console.WriteLine("Задайте размер массива");

    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Заполни массив");
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine("]");
}

int[] userarray = GetUserArray();
PrintArray(userarray);

int SerchPositivNumbers(int[] array)
{
    int result = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}
System.Console.WriteLine($"пользователь ввел {SerchPositivNumbers(userarray)} чисел больше нуля");
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetRandomArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

void PrintArray(int[] userarray)
{
    System.Console.Write("[");
    for (int i = 0; i < userarray.Length; i++)
    {
        System.Console.Write(userarray[i] + " ");
    }
    System.Console.Write("]");
}

int[] array = GetRandomArray(20);
PrintArray(array);

int Sum(int[] array)
{
    int result = 0;  
    for (int i = 1; i < array.Length; i+=2)
    {
        result = result + array[i];
    }
    return result;
}

Sum(array);
System.Console.WriteLine($"{Sum(array)}");
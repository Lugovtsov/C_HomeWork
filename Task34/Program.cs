/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetRandomArray()
{
    
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
}

int[] userArray = GetRandomArray();
PrintArray(userArray);

int SeaNum(int[] userArray)
{
    int result = 0;

    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    
    return result;
}

System.Console.WriteLine(SeaNum(userArray));
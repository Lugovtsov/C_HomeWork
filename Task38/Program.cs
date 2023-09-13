/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] GetRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(Math.Round(array[i],1) + " ");
    }
    System.Console.WriteLine("]");
}

double[] array = GetRandomArray(10);
PrintArray(array);

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = Math.Round(array[i],1);
        }
    }
    return min;
}

FindMin(array);
double min = FindMin(array);

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = Math.Round(array[i],1);
        }
    }
    return max;
}

double max = FindMax(array);
double dif = max - min;
System.Console.WriteLine($"Разница между {max} и {min} равна {Math.Round(dif),1}");
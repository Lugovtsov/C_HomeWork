/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

﻿/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/


int[,] MultiplicationMatrix(int[,] MatrixOne, int[,] MatrixTwo)
{
    int[,] result = new int[MatrixOne.GetLength(0), MatrixTwo.GetLength(1)];
    for (var i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (var j = 0; j < MatrixTwo.GetLength(0); j++)
        {
            for (var x = 0; x < MatrixTwo.GetLength(1); x++)
            {
                result[i, x] += MatrixOne[i, j] * MatrixTwo[j, x];
            }
        }
    }
    return result;
}
int[,] Array(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,5);
        }
    }
    return array;

}
Console.Write("Введите размер матрицы: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());
var MatrixOne = new int[sizeMatrix, sizeMatrix];
var MatrixTwo = new int[sizeMatrix, sizeMatrix];
int[,] MatrixArrOne = Array(sizeMatrix,sizeMatrix);
int[,] MatrixArrTwo = Array(sizeMatrix,sizeMatrix);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}
PrintArray(MatrixArrOne);
System.Console.WriteLine();
PrintArray(MatrixArrTwo);
System.Console.WriteLine();
int[,] result = MultiplicationMatrix(MatrixArrOne, MatrixArrTwo);
PrintArray(result);
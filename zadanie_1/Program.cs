﻿Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[m, n];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();    
}
﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

void CreateArray(int row, int col)
{
    int[,] arr = new int[3, 4];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    if (arr.GetLength(0) < row || arr.GetLength(1) < col)
    {
        Console.WriteLine($"[{row},{col}] -> такого числа в массиве нет " +
        $"[{row},{col}] - это позиция элемента, где {row} - строка, {col} - столбец");
    }
    else
    {
        Console.WriteLine($"[{arr[row-1, col-1]}] -> искомое число");
    }
}
CreateArray(1, 7);
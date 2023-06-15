// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}
void FindAveregeOfColumn(int[,] array)
{
    double[] storageArr = new double[array.GetLength(1)];
    int index = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double countAverage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            countAverage += array[i, j];
        }
        storageArr[index] = countAverage / (array.GetLength(0));
        index++; 
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    foreach (double item in storageArr)
    {
        Console.Write($"{Math.Round(item, 1)}; ");
    }
}
int[,] newArray = CreateArray(3, 4);
FindAveregeOfColumn(newArray);
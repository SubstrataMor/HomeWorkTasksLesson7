// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. //
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.//

int[,] CreateArray(int row, int col)    //
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)              //Сначала создаем массив
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}
void FindAveregeOfColumn(int[,] array)      //Затем создаем метод для обхода массива
{
    double[] storageArr = new double[array.GetLength(1)];   //Создаем дополнительный одномерный массив для хранения найденных значений
    int index = 0;
    for (int j = 0; j < array.GetLength(1); j++)        //Начинаем обход со столбцов
    {
        double countAverage = 0;                        //Задаем переменную для хранения данных
        for (int i = 0; i < array.GetLength(0); i++)    //Обход строк
        {
            countAverage += array[i, j];                //Помещаем в хранилище сумму всех найденных значений в столбце
        }
        storageArr[index] = countAverage / (array.GetLength(0));    //Делим число в хранилище на величину строк и сохраняем в новый массив
        index++; 
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    foreach (double item in storageArr)                 //Начинем обход всех элемнтов с выводом на консоль
    {
        Console.Write($"{Math.Round(item, 1)}; ");
    }
}
int[,] newArray = CreateArray(3, 4);
FindAveregeOfColumn(newArray);                          //
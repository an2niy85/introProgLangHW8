/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

Console.Write("Введите значение размера прямоугольного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillArray(n, n);
PrintArray(array);
Console.WriteLine();
RowLowSum(array);

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void RowLowSum(int[,] array)
{
    int[] RowSum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            RowSum[i] += array[i, j];
        }
        //Console.WriteLine(RowSum[i]);
    }

    int min = int.MaxValue;
    int indexMin = 0;
    for (int i = 0; i < RowSum.Length; i++)
    {
        if (RowSum[i] < min)
        {
            indexMin = i;
            min = RowSum[i];
        }
    }
    Console.WriteLine($"{indexMin + 1} строка");
}
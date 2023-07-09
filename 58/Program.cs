/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

Console.Write("Введите количество строк первого массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillArray(row, column);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите количество строк первого массива: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int column2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array2 = FillArray(row2, column2);
PrintArray(array2);
Console.WriteLine();

int[,] mult = MultTwoArray(array, array2);
PrintArray(mult);

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

int[,] MultTwoArray(int[,] array, int[,] array2)
{
    if (array.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй");
        return array;
    }
    int[,] mult = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                mult[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return mult;
}
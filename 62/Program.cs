/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

Console.Write("Введите размер дву мерного массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = FillSpiralArray(size);
PrintArray(array);

int[,] FillSpiralArray(int size)
{
    int[,] array = new int[size, size];
    int value = 1;

    int startX = 0;
    int startY = 0;

    int endX = size - 1;
    int endY = size - 1;

    while (startX <= endX && startY <= endY)
    {
        for(int i = startY; i <= endY; i++)
        {
            array[startX,i] = value++;
        }

        startX++;

        for(int i = startX; i <= endX; i++)
        {
            array[i,endY] = value++;
        }

        endY--;

        for(int i = endY; i >= startY; i--)
        {
            array[endX,i] = value++;
        }

        endX--;

        for(int i = endX; i >= startX; i--)
        {
            array[i,startY] = value++;
        }

        startY++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("D2")} ");
        }
        Console.WriteLine();
    }
}
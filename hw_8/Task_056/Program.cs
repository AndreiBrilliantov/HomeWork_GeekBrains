/*

Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

Console.Clear();
int[,] CreateArray(int row, int col, int min, int max) {
    Random rand = new Random();
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max+1);
        }
    }
    return array;
}

void PrintArray(int [,] array) {
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

(int resultMinSum, int rowNumber) GetMinSumRow(int[,] array) {
    int resultMinSum = 0;
    int resultIdx = 0;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        int minSum = 0;
        for (int j = 0; j < col; j++)
        {
            minSum += array[i,j];
        }
        if (i == 0)
        {
            resultMinSum = minSum;
            resultIdx = i;
        }
        if (minSum < resultMinSum)
        {
            resultMinSum = minSum;
            resultIdx = i;
        }
    }
    return (resultMinSum, resultIdx);
}

int [,] array = CreateArray(3, 2, 2, 10);
PrintArray(array);
(int minSum, int rowNum) res = GetMinSumRow(array);
Console.WriteLine($"{res.minSum} - Min sum in line {res.rowNum + 1}");
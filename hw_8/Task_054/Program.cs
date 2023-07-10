/*

Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

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

int[,] SortByRow(ref int[,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int idx = 0; idx < row; idx++)
    {
        for (int i = 0; i < col-1; i++)
        {
            for (int j = 0; j < col-1-i; j++)
            {
                if(array[idx, j] < array[idx, j+1]) {
                    int temp = array[idx, j];
                    array[idx, j] = array[idx, j+1];
                    array[idx, j+1] = temp;
                }
            }
        }
    }
    return array;
}

int [,] array = CreateArray(3, 4, 10, 100);
PrintArray(array);
SortByRow(ref array);
Console.WriteLine();
PrintArray(array);

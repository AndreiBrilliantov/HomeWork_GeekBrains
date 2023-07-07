/*

Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArrInt(int [,] array) {
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

double[] GetAveregeByCol(int[,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double[] averegeArr = new double[col];
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            averegeArr[i] += array[j,i];
        }
        averegeArr[i] = Math.Round(averegeArr[i] / row, 2);
    }
    return averegeArr;
}

int [,] array = CreateArray(3, 4, 0, 10);
PrintArrInt(array);
double[] averegeArr = GetAveregeByCol(array);
Console.WriteLine("Averege by COL:");
Console.WriteLine($"{string.Join("\t", averegeArr)}");

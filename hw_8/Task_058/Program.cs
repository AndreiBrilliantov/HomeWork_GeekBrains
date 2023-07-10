/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

//Console.Clear();
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

bool CheckMatrix (int [,] matrix1, int [,] matrix2) {

    return (matrix1.GetLength(1) == matrix2.GetLength(0)) ? true : false; // col1 == row2
}

(bool isComplete, int[,] matrix) MatrixMultiplication(int [,] matrix1, int [,] matrix2) {
    // (m x n) * (n x k) = (m x k)
    if(CheckMatrix(matrix1, matrix2)) {
        (int row, int col) dimensionMatrix1 = (matrix1.GetLength(0), matrix1.GetLength(1));
        (int row, int col) dimensionMatrix2 = (matrix2.GetLength(0), matrix2.GetLength(1));
        (int row, int col) dimensionMatrix3 = (dimensionMatrix1.row, dimensionMatrix2.col);
        int nLen = dimensionMatrix1.col;
        int[,] matrix3 = new int[dimensionMatrix3.row, dimensionMatrix3.col];

        for (int i = 0; i < dimensionMatrix3.row; i++)
        {
            for (int j = 0; j < dimensionMatrix3.col; j++)
            {
                for (int n = 0; n < nLen; n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
                
            }
        }
        return (true, matrix3);
    }
    return (false, null);

}

int [,] matrix1 = CreateArray(3, 2, 2, 10);
PrintArray(matrix1);
Console.WriteLine();

int [,] matrix2 = CreateArray(2, 3, 2, 10);
PrintArray(matrix2);
var resultMatrixMultiplication = MatrixMultiplication(matrix1, matrix2);
Console.WriteLine();

if(resultMatrixMultiplication.isComplete){
    Console.WriteLine("Результат перемножения:");
    PrintArray(resultMatrixMultiplication.matrix);
}
else {
    Console.WriteLine("Не получилось перемножить матрицы. Проверьте их размерность.");
}
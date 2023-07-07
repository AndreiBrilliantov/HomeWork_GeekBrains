/*

Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/
Console.Clear();
void OutNumber((int, int) positionEl, string txt) {
    Console.WriteLine($"{string.Join(", ", positionEl)} -> {txt}");
}
int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    int number;
    while (true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number \"{temp}\" is not correct. Try again =>");
    }
}
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
(bool isGettings, int element) GetElement(int[,] array, int rowNumber, int colNumber){
    return (array.GetLength(0) < rowNumber || array.GetLength(1) < colNumber) ? (false, 0) : (true, array[rowNumber,colNumber]);
}
int [,] array = CreateArray(3, 4, -100, 100);
PrintArray(array);
(int row, int col) positionEl = (InputNumber("Input row number"), InputNumber("Input col number"));
var el = GetElement(array, positionEl.row - 1, positionEl.col - 1);

if(el.isGettings){
    OutNumber(positionEl, Convert.ToString(el.element) );
}
else
{
    OutNumber(positionEl, "такого элемента в массиве нет");
}
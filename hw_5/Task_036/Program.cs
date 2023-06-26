/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


*/

int [] CreateArray(int size, int min, int max){
    int [] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

int GetSum(int [] array) {
    int arrLen = array.Length;
    int sum = 0;
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        sum += array[i];
    }
    return sum;
}

void OutNumber(int[] number, int number2) {
    Console.WriteLine($"{string.Join(", ", number)} -> {number2}");
}
int[] array = CreateArray(4, -10, 11);
int sum = GetSum(array);
OutNumber(array, sum);
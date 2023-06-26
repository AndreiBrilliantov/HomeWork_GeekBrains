/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

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
int GetEvenNumFromArray(int[] array){
    int count = 0;
    foreach (int el in array)
    {
        if(el % 2 == 0){
            count++;
        }
            
    }
    return count;
}
void OutNumber(int[] number, int number2) {
    Console.WriteLine($"{string.Join(", ", number)} -> {number2}");
}
int[] array = CreateArray(5, 100, 1000);
int countEven = GetEvenNumFromArray(array);
OutNumber(array, countEven);
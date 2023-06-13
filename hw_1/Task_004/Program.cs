/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int[] numbers = new int[3];
int arrLen = 3;
for (int i = 0; i < arrLen; i++)
{
    Console.WriteLine("Write " + (i+1) + " number");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int max = numbers[0];
for (int i = 1; i < arrLen; i++)
{
    if(max < numbers[i]){
        max = numbers[i];
    }
}
Console.WriteLine("max = " + max);
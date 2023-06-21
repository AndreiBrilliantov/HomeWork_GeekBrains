/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


void OutArrays(int[] array1) {
    Console.WriteLine($"{string.Join(", ",array1)} -> [{string.Join(", ",array1)}]");
}

int[] numberArray = {1, 2, 4, 7, 9, 7};
OutArrays(numberArray);
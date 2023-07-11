/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/


int GetSumNaturalRec(int m, int n){
    if(n < m) return 0;
    return n + GetSumNaturalRec(m , n-1);
}

Console.WriteLine(GetSumNaturalRec(1, 15));
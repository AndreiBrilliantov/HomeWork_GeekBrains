/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
    
*/

int AcermanRec(int m, int n){
    if(m == 0) return n + 1;
    else {
        if(n == 0)
            return AcermanRec(m - 1, 1);
    }
    return AcermanRec(m - 1, AcermanRec(m, n - 1));
}

Console.WriteLine(AcermanRec(3,2));
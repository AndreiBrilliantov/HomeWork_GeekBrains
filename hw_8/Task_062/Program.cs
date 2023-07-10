/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/
int[,] GetSpiral(int N){
    int[,] a = new int [N,N];
    for (int ik = 0; ik < N; ik++)
    {
        for (int jk = 0; jk < N; jk++)
        {
            int i = ik + 1;
            int j = jk + 1;
            // Сначала честно пытался связать со Спиралью Архмеда, но как-то неособо получилось
            int switcher =  (j - i + N) / N;
            int Ic = Math.Abs(i - N / 2  - 1) + (i - 1)/(N /2) * ((N-1) % 2);
            int Jc = Math.Abs(j - N / 2  - 1) + (j - 1)/(N /2) * ((N-1) % 2);
            int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = i - Ring + j - Ring - 1;    
            int Coef =  4 * Ring * (N - Ring);
            a[ik, jk] =  Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);
            Console.Write($"{a[ik, jk]}\t");

        }
        Console.WriteLine();
    }
    return a;
}

int[,] matrix = GetSpiral(4);
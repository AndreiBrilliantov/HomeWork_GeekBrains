/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

//Console.Clear();
int GetUniqRandom(int min, int max, int[,,] array1){
    Random rand = new Random();    
    bool flag = true;
    int rndNum = 0;
    while(flag){
        rndNum = rand.Next(min, max);
        
        foreach (int item in array1)
        {
            if(item == rndNum)
            {
                flag = true;
                break;
            }
            else flag = false;
        }
    }
    return rndNum;
}

int[,,] CreateArray(int x, int y, int z, int min, int max) {
    int [,,] array = new int [x, y, z];
    int newRndNum;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int t = 0; t < z; t++)
            {
                array[i, j, t] = GetUniqRandom(min, max, array); 
            }
            
        }
    }
    return array;
}

void PrintArray(int [,,] array) {
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int t = 0; t < z; t++)
            {
                (int, int, int) idx = (i, j ,t);
                Console.Write($"{array[i,j,t]} {string.Join(", ", idx)}\t");
            }
            Console.WriteLine();
        }
        
    }
}

int [,,] matrix = CreateArray(x:2, y:2, z:2, min:10, max:18);
PrintArray(matrix);
Console.WriteLine();
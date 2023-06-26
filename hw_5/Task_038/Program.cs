/*

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

*/


double [] CreateArray(int size, double min, double max){
    double [] array = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble() * (max - min) + min;
    }
    return array;
}

void OutNumber(double[] number, string txt) {
    Console.WriteLine($"[{string.Join(", ", number)}] -> {txt}");
}

double[] array = CreateArray(4, 10, 100);
double arrMax = array.Max();
double arrMin = array.Min();
double diff = arrMax - arrMin;
string txt = $"{arrMax} - {arrMin} = {diff}";
OutNumber(array, txt);
/*

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/
int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void OutNumberArr(int number, int[] arr) {
    Console.WriteLine($"{number} -> {String.Join(", ", arr)}");
}
int[] NumberPowers(int number, int power) {
    int[] powArr = new int[number];
    for (int i = 1; i <= number; i++)
    {
    powArr[i - 1] = Convert.ToInt32(Math.Pow(i , power));
    }
    return powArr;
}

int number = InputNumber();
int power = InputNumber($"To what degree should the number {number} be raised?");
OutNumberArr(number, NumberPowers(number, power));

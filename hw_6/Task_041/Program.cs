/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/
void OutNumber(int[] number, int number2) {
    Console.WriteLine($"{string.Join(", ", number)} -> {number2}");
}

int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    int number;
    while (true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number \"{temp}\" is not correct. Try again =>");
    }
}

int[] InputArray(int size){
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = InputNumber($"Input {i+1}/{size} number");
    }
    return arr;
}

bool IsGreaterThanZero(int num){
    return num > 0 ? true : false;
}

int NumGreaterThanZero(int[] arr){
    int count = 0;
    foreach (int el in arr)
    {
        count += IsGreaterThanZero(el) ? 1 : 0;
    }
    return count;
}

int size = InputNumber("Input array size");
int[] arr = InputArray(size);
OutNumber(arr, NumGreaterThanZero(arr));
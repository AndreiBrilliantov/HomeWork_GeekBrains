/*

Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

*/
int GetRndNum(int fromNum, int toNum) {
    int number = new Random().Next(fromNum, toNum);
    Console.WriteLine($"Random number is {number}");
    return number;
}

void OutNumber(int number, string str1) {
    Console.WriteLine($"{number} -> {str1}");
}



int number = GetRndNum(100, 1000);
int thirdDigit = number % 100 / 10;
OutNumber(number, Convert.ToString(thirdDigit));
//PS в след таске (_015) поинтереснее
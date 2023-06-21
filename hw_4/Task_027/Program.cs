/*

Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

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

void OutNumber(int number, int number2) {
    Console.WriteLine($"{number} -> {number2}");
}

int digitSum(int number){
    int count = (int) Math.Log10(number) + 1;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        int digit = number % 10;
        sum+= digit;
        number /= 10;
    }
    return sum;
}

int number = InputNumber();
OutNumber(number, digitSum(number));
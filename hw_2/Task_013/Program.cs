/*

Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void OutNumber(int number, string str1) {
    Console.WriteLine($"{number} -> {str1}");
}

void GetDigitOfNumber (int number, int digitPos) 
{
    int digitPos_ = Convert.ToInt32(Math.Pow(10, digitPos - 1 ));
    int digit = Math.Abs(number);
    if (number / digitPos_ > 0)
    {
        while (digit >= 10 )
        {
            digit = (digit / digitPos_ < 10) ? (digit % 10) : (digit / 10);
        }
        OutNumber(number, Convert.ToString(digit));
    }
    else
    {
        OutNumber(number, $"{digitPos} цифры нет");
    }    
    
}

GetDigitOfNumber(InputNumber("Укажите число:"), InputNumber("Укажите позицию в числе:"));

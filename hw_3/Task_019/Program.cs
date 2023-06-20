/*

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

*/

int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void OutNumber(int number, string str1) {
    Console.WriteLine($"{number} -> {str1}");
}

int NumberOfDigits (int number) {
    int digits = 0;
    while (number != 0)
    {
        number = number / 10;
        digits += 1;
    }
    return digits;
}

bool IsPalindrome(int number, int digitsCount)
{
    number = Math.Abs(number);
    for (int i = 1; i <= digitsCount; i++)
    {
        int digit_1 = number % Convert.ToInt32(Math.Pow(10, i));
        digit_1 = i > 1 ? digit_1 / Convert.ToInt32(Math.Pow(10, i -1)) : digit_1;

        int digit_2 = number / Convert.ToInt32(Math.Pow(10, digitsCount - i));
        digit_2 = i > 1 ? digit_2 % 10 : digit_2;

        if(digit_1 != digit_2)
        {
            return false;
        }
        
    }
    return true;
}

int number = InputNumber();
int digitsCount = NumberOfDigits(number);

if( IsPalindrome(number, digitsCount) )
{
    OutNumber(number, "Palindrome");
}
else
{
    OutNumber(number, "Not a palindrome");
}
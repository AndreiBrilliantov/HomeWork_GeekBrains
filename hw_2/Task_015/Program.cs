/*

Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/


int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void OutNumber(int number, string str1) {
    Console.WriteLine($"{number} -> {str1}");
}
bool InArray(int[] arr, int sNumber){
    foreach ( int item in arr)
    {
        if( item == sNumber )
        {
            return true;
        }
    }
    return false;
}


int[] weekendDays = new int[]{6, 7};
int number = InputNumber();
while (number < 1 || number > 7)
{
    OutNumber(number, "Not the number of the day of the week!");
    number = InputNumber();
}

switch (InArray(weekendDays, number))
{
    case true:
        OutNumber(number, "Da");
        break;
    case false:
        OutNumber(number, "Net");
        break;
}
/*
if (InArray(weekendDays, number))
{
    OutNumber(number, "Da");
}
else 
{
    OutNumber(number, "Net");
}
*/
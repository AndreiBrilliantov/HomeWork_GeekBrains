/*

Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/


int InputNumber() {
    Console.WriteLine("Input your day number =>");
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

int number = InputNumber();
while (number < 1 || number > 7)
{
    Console.WriteLine("Not the number of the day of the week!");
    number = InputNumber();
}
int[] weekendDays = new int[]{6, 7};
if (InArray(weekendDays, number))
{
    OutNumber(number, "Da");
}
else 
{
    OutNumber(number, "Net");
}
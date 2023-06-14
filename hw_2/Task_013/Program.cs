/*

Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

Console.WriteLine("Input your number =>");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
if (number / 100 > 0)
{
    while (number >= 10 )
    {
        number = (number / 100 < 10) ? (number % 10) : (number / 10);
    }
    Console.Write(number);
}
else
{
    Console.Write("третьей цифры нет");
}

/*

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Input your number =>");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + " -> ");
for (int i = 0; i <= number; i += 2)
{
    if(i % 2 == 0 && i != 0) {
        Console.Write(i);
        if(i != number) 
            Console.Write(", ");
    }
}

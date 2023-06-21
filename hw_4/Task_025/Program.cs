/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

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

void OutNumber(int[] number, int number2) {
    Console.WriteLine($"{string.Join(", ", number)} -> {number2}");
}

int[] inputPowNumber() {
    int[] numPow = new int[2];
    for (int i = 0; i < 2; i++)
    {
        switch (i)
        {
            case 0:
                numPow[i] = InputNumber();
                break;
            case 1:
                numPow[i] = InputNumber("Input power for number =>");
                break;
        }
    }
    //Console.WriteLine(String.Join(", ", numPow));
    return numPow;
}
int[] numPow = inputPowNumber();
OutNumber(numPow, (int) Math.Pow(numPow[0], numPow[1]));

/*

Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/
void OutNumber((int k1, int b1, int k2, int b2) lineKoef, (double pointX, double pointY) p) {
    Console.WriteLine($"b1 = {lineKoef.b1}, k1 = {lineKoef.k1}, b2 = {lineKoef.b2},  k2 = {lineKoef.k2} -> ({p.pointX}; {p.pointY})");
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
(int k1, int b1, int k2, int b2) InputKoefLine() {
    return (
        k1:InputNumber("Input k1 for first line"),
        b1:InputNumber("Input b1 for first line"),
        k2:InputNumber("Input k2 for second line"),
        b2:InputNumber("Input b2 for second line")
        );
}
(double pointX, double pointY) GetIntersectionPoint((int, int, int, int) lineKoef){
    // y = kx+b
    // (b2 - b1) / (k1 - k2) = x
    (int k1, int b1, int k2, int b2) = lineKoef;
    double x, y;
    x = (double) (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    return (pointX: x, pointY: y);
}
var koef = InputKoefLine();
var points = GetIntersectionPoint(koef);
OutNumber(koef, points);
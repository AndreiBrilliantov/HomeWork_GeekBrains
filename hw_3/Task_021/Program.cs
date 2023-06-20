/*

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int InputNumber(string msg = "Input your number =>") {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void OutPoint(string namePoint, int[] arr) {
    Console.Write($"{namePoint} ({String.Join(", ", arr)});");
}
int[] InputPointCoordinate() {
    int[] coordinate = new int[3];
    string[] xyz = {"X", "Y", "Z"};
    for (int i = 0; i < coordinate.Length; i++)
    {
        coordinate[i] = InputNumber($"Input {xyz[i]} coordinate for point ");
    }
    return coordinate;
}
double GetDistance(int[] firstPoint, int[] secondPoint){
    double summ = 0;
    for (int i = 0; i < 3; i++)
    {
        summ += Math.Pow((firstPoint[i] - secondPoint[i]), 2);
    }
    //double distance = Math.Sqrt( summ );
    return Math.Sqrt( summ );
}
Console.WriteLine("Input FIRST point:");
int[] firstPoint = InputPointCoordinate();
Console.WriteLine("Input SECOND point:");
int[] secondPoint = InputPointCoordinate();
OutPoint("A", firstPoint);
OutPoint("B", secondPoint);
Console.Write(" -> " + GetDistance(firstPoint, secondPoint));
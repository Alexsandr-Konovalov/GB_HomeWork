// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("По оси Х -> ");
double XA = int.Parse(Console.ReadLine()!);
Console.Write("По оси Y -> ");
double YA = int.Parse(Console.ReadLine()!);
Console.Write("По оси Z -> ");
double ZA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("По оси Х -> ");
double XB = int.Parse(Console.ReadLine()!);
Console.Write("По оси Y -> ");
double YB = int.Parse(Console.ReadLine()!);
Console.Write("По оси Z -> ");
double ZB = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2) + Math.Pow(ZB - ZA, 2));
Console.Write(AB);
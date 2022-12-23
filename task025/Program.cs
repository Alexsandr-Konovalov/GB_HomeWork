// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Не используя Math.Pow!

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите два числа через пробел -> ");

string[] num = Console.ReadLine()!.Split(' ');
int A = int.Parse(num[0]);
int B = int.Parse(num[1]);
int Q = 1;

for (int i = 1; i <= B; i++)
{
    Q = Q * A;
}
Console.Write(Q);


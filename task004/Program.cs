// Задача №4
// Выяснить является ли число чётным

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("Это число четное!");
}
else
{
    Console.WriteLine("Это НЕ четное число!");
}

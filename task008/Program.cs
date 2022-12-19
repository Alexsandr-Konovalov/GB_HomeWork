// Задача №8
// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное число -> ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{number / 100}{number % 10}");



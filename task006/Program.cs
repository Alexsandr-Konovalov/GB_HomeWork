// Задача №6
// Показать вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное число -> ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(number % 100 / 10);

// Задача №5
// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трёхзначное число -> ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(number % 10);
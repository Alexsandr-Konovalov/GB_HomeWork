// Задача №9
// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.Write("Задайте число -> ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число -> ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 % number2 == 0)
{
    Console.WriteLine($"Первое число {number1} кратно второму числу {number2}");
}
else{
    Console.WriteLine($"Первое число {number1} НЕ кратно второму числу {number2} и остаток равен {number1 % number2}");
}

// Задача №7
// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число -> {number}");

int x1 = number / 10;
int x2 = number % 10;

if (x1 > x2)
{
    Console.WriteLine($"Наибольшая цифра -> {x1}");
}
else
{
    Console.WriteLine($"Наибольшая цифра -> {x2}");
}



// Задача №3
//Найти максимальное из трех чисел

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);

// другой способ решения:

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// Console.Write("Введите первое число ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число ");
// int b = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число ");
// int c = int.Parse(Console.ReadLine()!);

// int max = Max(a, b, c);

// Console.WriteLine(max);
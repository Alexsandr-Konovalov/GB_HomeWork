// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите нужное количество чисел -> ");
string[] stringNum = Console.ReadLine()!.Split(' ');
int count = 0;

for (int i = 0; i < stringNum.Length-1; i++)
{
    string Q = Convert.ToString(stringNum[i]);
    int W = Convert.ToInt32(Q);
    if (W > 0) count++;
}
Console.Write(count);

//Задача №19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число -> ");
int num = int.Parse(Console.ReadLine()!);
string strNum = $"{num}";

if (strNum[0] == strNum[4] && strNum[1] == strNum[3])
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}

// другой способ

Console.Write("Введите пятизначное число -> ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num;
int revers = 0;
int i = 0;
while (num > 0)
{
    i = num % 10;
    revers = revers * 10 + i;
    num = num / 10;
}
if (num1 == revers)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");
}
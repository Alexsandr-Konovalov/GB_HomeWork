// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели от 1 до 7");
// int day = int.Parse(Console.ReadLine()!);
// int a = 1;
// int b = 2;
// int c = 3;
// int d = 4;
// int i = 5;
// int f = 6;
// int g = 7;
// if (day == a){
//     Console.WriteLine("Понедельник");
// }
// if (day == b){
//     Console.WriteLine("Вторник");
// }
// if (day == c){
//     Console.WriteLine("Среда");
// }
// if (day == d){
//     Console.WriteLine("Четверг");
// }
// if (day == i){
//     Console.WriteLine("Пятница");
// }
// if (day == f){
//     Console.WriteLine("Суббота");
// }
// if (day == g){
//     Console.WriteLine("Воскресенье");
// }
// Console.WriteLine("Этот день выходной?");

// if (day <= 5){
//     Console.WriteLine("Нет, это будний день :(");
// }

// if (day >= 6){
//     Console.WriteLine("Да! Бежим отдыхать! :D");
// }

Console.Write("Введите день недели -> ");
int Day = int.Parse(Console.ReadLine()!);
int [] arrDay = {1, 2, 3, 4, 5, 6, 7};
if (Day >= arrDay.Length - 1 && Day < 8)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

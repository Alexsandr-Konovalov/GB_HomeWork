// Задача № 2
// По заданному номеру дня недели вывести его название

string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Задайте день недели -> ");
int numberDays = int.Parse(Console.ReadLine()!);

Console.WriteLine(Days[numberDays - 1]);



// Доп. задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Write("Введите любое целое число -> ");
int numberInt = Convert.ToInt32(Console.ReadLine()!);
int d = 0;
string j = "";


while (numberInt >= 1)
{
    d = numberInt % 2;
    numberInt = numberInt / 2;
    j =  j + Convert.ToString(d);
}
Console.WriteLine(j);

string[] array = new string[j.Length];

for (int i = 0; i < j.Length - 1; i++)
{
    array[0] = array[j.Length - 1 - i];
    
}
Console.Write(array);



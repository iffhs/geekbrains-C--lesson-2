﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
//326792 -> 6

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
while (n >= 1000)
{
n = n/10;
}
int k = n % 10;
Console.WriteLine($"Третья цифра заданного равна : {k} ");
}
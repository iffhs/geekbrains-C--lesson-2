// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введие трёхзначнок число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n.ToString().Length;
if (a == 3 )
{
Console.WriteLine((n%100)/10);
}
else
{
Console.WriteLine("Вы ввели не трёхзначное число");
}
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a == 6 || a ==7)
{
Console.WriteLine("Да");
}
if (a > 7)
{
Console.WriteLine("Всего 7 дней в неделе");
}
else
{
Console.WriteLine("Нет");
}
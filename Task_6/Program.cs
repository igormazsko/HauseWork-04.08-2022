// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
using static System.Console;
Clear();
WriteLine("Введите число");
double namber = Convert.ToDouble(ReadLine());
double namber1 = namber % 2;
if (namber1 == 0)
{
    WriteLine("Да, чётное");
}
else
{
    WriteLine("Нет, не четное");
}
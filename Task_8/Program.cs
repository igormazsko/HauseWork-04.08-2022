// Задача 8: Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
using static System.Console;
Clear();
WriteLine("Введите число N");
double namberN = Convert.ToDouble(ReadLine());
double i = 1;
while (i <= namberN)
{
    double namber = i % 2;
    if (namber == 0)
    {
        WriteLine(i);
    }
    i++;
}
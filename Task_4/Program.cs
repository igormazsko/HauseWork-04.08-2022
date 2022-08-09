// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
using static System.Console;
Clear();
WriteLine("Введите первое число");
int namberA = int.Parse(ReadLine());
WriteLine("Введите второе число");
int namberB = int.Parse(ReadLine());
WriteLine("Введите третье число");
int namberC = int.Parse(ReadLine());
int m = namberA;
if (namberB > m)
{
    m = namberB;
}
if (namberC > m)
{
    m = namberC;
}
Write("max = ");
WriteLine(m);
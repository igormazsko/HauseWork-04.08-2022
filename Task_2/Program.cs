// Задача 2:Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее
using static System.Console;
Clear();
WriteLine("Введите первое число");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число");
int b = int.Parse(ReadLine());
if (a>b)
{
    Write("Большее - ");
    WriteLine(a);
    Write("Меньшее - ");
    WriteLine(b);
}
else
{
    Write("Большее - ");
    WriteLine(b);
    Write("Меньшее - ");
    WriteLine(a);
}
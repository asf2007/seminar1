﻿int Remainder(int num1, int num2)
{
    return num1 % num2;
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int remaind = Remainder(num1, num2);
if (remaind == 0)
{
    Console.Write($"{num1}, {num2} -> кратно");
}
else
{
    Console.Write($"{num1}, {num2} -> некратно, остаток {remaind}");
}

bool square(int num1, int num2)
{
    bool square = false;
    if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        square = true;
    }
    return square;
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (square(num1, num2))
{
    Console.Write($"{num1}, {num2} -> да");
}
else
{
    Console.Write($"{num1}, {num2} -> нет");
}

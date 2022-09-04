bool Remainder(int num)
{
    bool div = false;
    if (num % 7 == 0 && num % 23 == 0)
    {
        div = true;
    }
    return div;
}
Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool div = Remainder(num);
if (div)
{
    Console.Write($"{num} -> да");
}
else
{
    Console.Write($"{num} -> нет");
}

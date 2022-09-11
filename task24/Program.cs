Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine($"{num} -> {SumNum(num)}");
int DelDig(int num)
{
    int doubNum = -1;
    if (num > 99 && num < 1000)
    {
        int firstDig = num / 100;
        int lastDig = num % 10;
        doubNum = firstDig * 10 + lastDig;
    }
    return doubNum;
}
int number = new Random().Next(100, 1000);

Console.WriteLine($"{number} -> {DelDig(number)}");

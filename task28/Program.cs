Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Fact(int num){
    int fact = 1;
    for(int i = 1; i<=num; i++){
        fact=fact*i;
    }
    return fact;
}
Console.Write($"{num} -> {Fact(num)}");


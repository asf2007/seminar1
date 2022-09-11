Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int CountNum(int num){
    int i=0;
for(i = 0; num>0; i++){
    num=num/10;
}
return i;
}

Console.Write($"{num} -> {CountNum(num)}");
int num = new Random().Next(10, 100);
int firstDig = num/10;
int secondDig = num%10;


int max = firstDig > secondDig ? firstDig : secondDig;

int MaxDig(int num){
int firstDig = num/10;
int secondDig = num%10; 
if(firstDig==secondDig){
   return 0;
}
else
int max = firstDig > secondDig ? firstDig : secondDig;
return max;
}
int maxDig = MaxDig(num);
Console.WriteLine($"наибольшая цифра числа {num} равна {maxDig}");
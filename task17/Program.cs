int GetQuarter(int x, int y){
    int quarter =-1;
    if(x>0&&y>0){
        quarter=1;
    }
    else if(x>0&&y<0){
        quarter=2;
    }
    else if(x<0&&y<0){
        quarter=3;
    }
    else if (x<0&&quarter>0){
        quarter=4;
    }
    return quarter;
}

Console.Write("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());
int quarter = GetQuarter(x,y);
if(quarter==-1){
    Console.Write("Ошибка!! Координаты не должны быть равны нулю");
}
else{
   Console.Write($"({x}, {y}) -> {quarter}"); 
}


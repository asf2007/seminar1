string Range(int quarter){
    if(quarter==1){
        return "диапазон: x>0 и Y>0";
    }
    if(quarter==2){
        return "диапазон: x>0 и Y<0";
    }
    if(quarter==3){
        return "диапазон: x<0 и Y<0";
    }
    if(quarter==4){
        return "диапазон: x<0 и Y<0";
    }
    return "Неверное значение!!! Четверь должна быть от 1 до 4";
}
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.Write($"{quarter} -> {Range(quarter)}");

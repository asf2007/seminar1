double Distance(int ax, int ay, int bx, int by){
    double distance = Math.Sqrt(((bx-ax)*(bx-ax))+((by-ay)*(by-ay)));
    if(distance<0){
        return distance*-1;
    }
    else return distance;
}
Console.Write("Введите координату x точки A : ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A : ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B : ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B : ");
int by = Convert.ToInt32(Console.ReadLine());

Console.Write($"A({ax}, {ay}); B({bx}, {by}) -> {Distance(ax, ay, bx, by)}");


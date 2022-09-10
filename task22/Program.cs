int[] Mult(int num){
    int [] mult = new int[num];
    int i = 0;
    while (i<num){
        mult[i]=(i+1)*(i+1);
        i++;
    }
    return mult;

}
string WriteArray(int [] array){
    string str = " ";
for(int i =0; i<array.Length; i++){
str=str+$"{array[i]}, ";
}
return str;
}
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> {WriteArray(Mult(num))}");

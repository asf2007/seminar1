int [] CreateNewArrRnd(int size, int min, int max){
    int []array = new int[size];
    Random rnd = new Random();
    for(int i=0; i<array.Length; i++ ){
        array[i]=rnd.Next(min, max+1);
    }
    return array;
}
void ArrWriter(int[]arr){
    Console.Write("[");
for(int i = 0; i<arr.Length; i++){
    if(i<arr.Length-1){
    Console.Write($"{arr[i]},");
}
else {
    Console.Write($"{arr[i]}");
}
}
Console.Write("]");
}
int[]Invert (int[]array){
    int[]invArr = new int[array.Length];
    for(int i = 0; i<array.Length; i++){
        invArr[i]=array[i]*-1; 
    }
    return invArr;

}
int [] array = CreateNewArrRnd(5, -9, 9);

ArrWriter(array);
Console.Write(" -> ");
ArrWriter(Invert(array));

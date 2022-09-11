int[]ArrMaker(){
    int[] arr = new int[8];
    for(int i = 0; i<arr.Length; i++){
        arr[i] = new Random().Next(0,2);
    }
    return arr;
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
ArrWriter(ArrMaker());

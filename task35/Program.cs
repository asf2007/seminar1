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
int ArrCount(int [] arr, int fromCount, int toCount ){
    int count = 0;
    for(int i=0; i<arr.Length; i++){
        if(arr[i]>=fromCount&&arr[i]<=toCount){
            count++;
        }
        
    }
return count;
}

int[]arr=CreateNewArrRnd(123,1,1000);
ArrWriter(arr);
Console.Write($" -> {ArrCount(arr, 10, 99)}");



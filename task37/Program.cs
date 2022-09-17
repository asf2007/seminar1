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
int[]MultPair(int[]arr){
    int [] mPairs = new int[arr.Length/2];
    for(int i=0, j=arr.Length-1; j>i; i++, j-- ){
        mPairs[i]=arr[i]*arr[j];
    } 
    return mPairs;
}

int[]arr=CreateNewArrRnd(10, 1, 10);
ArrWriter(arr);
Console.Write(" -> ");
ArrWriter(MultPair(arr));
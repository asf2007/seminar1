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

string Sum (int [] array){
    int sumMin=0;
    int sumPlus=0;
    for(int i = 0; i< array.Length; i++){
        if(array[i]<0){
            sumMin+=array[i];
        }
        else{
            sumPlus+=array[i];
        }
    }
    return $"minusSum={sumMin}, plusSum={sumPlus}";
} 
int[] array = CreateNewArrRnd(12, -9, 9);
ArrWriter(array);
Console.WriteLine($" -> {Sum(array)}");

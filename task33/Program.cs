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

bool FindNum(int [] array, int num){
    for(int i=0; i<array.Length; i++){
        if(array[i]==num){
            return true;
        }
    }
    return false;
}

int [] array = CreateNewArrRnd(5,-9,9);
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ArrWriter(array);
Console.Write(" -> ");
Console.Write($"{FindNum(array, num)}");
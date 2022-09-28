Console.Clear();
Console.WriteLine("Введите числа через пробел для создания массива");
string[] stringArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


bool Valid(string[] stringArr){
    if(stringArr.Length == 0){
        Console.WriteLine("Массив задан пустым");
        return false;
    }
    return true;
}
bool valid =  Valid(stringArr);

if(!valid){
    return;
}

int СheckLengthArray(string[] stringArr)
{   
    int arrLength = 0;
    Console.WriteLine(stringArr[0].Length<=3);
    for(int i=0; i<stringArr.Length; i++){
        if(stringArr[i].Length<=3){
            arrLength++;
        }
    }
    return arrLength;
}
Console.WriteLine(СheckLengthArray(stringArr));
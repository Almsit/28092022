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
    for(int i=0; i<stringArr.Length; i++){
        if(stringArr[i].Length<=3){
            arrLength++;
        }
    }
    return arrLength;
}



string[] СheckArray(string[] stringArr, int arrLength)
{   
    string[] arr_temp = new string[arrLength];
    int arr_i = 0;
    for(int i=0; i<stringArr.Length; i++){
        if(stringArr[i].Length<=3){
            arr_temp[arr_i] = stringArr[i];
            arr_i++;
        }
    }
    return arr_temp;
}

void PrintArray(string[] stringArr){
    string result = "";
    for(int i = 0; i<stringArr.Length; i++){
        if(result == ""){
            result = stringArr[i];
        } else {
            result += ", "+stringArr[i];
        }
    }
    result = "["+result+"]";
    Console.WriteLine(result);
}   


PrintArray(СheckArray(stringArr, СheckLengthArray(stringArr))); 
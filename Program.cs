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

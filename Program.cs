// https://gbcdn.mrgcdn.ru/uploads/asset/4312773/attachment/ed8c1f2c15da325114976e1c313ef5f8.png

string[] arrayIn = GetStrArr();
string[] arrayOut = GetStrArrLenghtLower3(arrayIn);
PrintArray(arrayOut);

string[] GetStrArr()
{
    string inputString;
    string[] arrRes;
    Console.Write("Вводите строки массива разделяя их запятой (если не заполнить, будет массив по умолчанию): ");
    inputString = Console.ReadLine()!;
    if(inputString.Length > 0){
        char[] separators = new char[]{','};
        arrRes = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }else{
        arrRes = new string[4]{"hello", "2", "world", ":-)"};
    }
    return arrRes;
}

string[] GetStrArrLenghtLower3(string[] arr)
{
    string str = string.Empty;
    int count = 0;
    string[] arrRes;
    foreach (var i in arr)
    {
        if(i.Length <= 3){
            str += i + ",";
            count++;
        }
    }
    if(count > 0){
        char[] separators = new char[]{','};
        arrRes = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }else{
        arrRes = new string[0];
    }
    return arrRes;
}

void PrintArray(string[] arr){
    Console.WriteLine("[" + String.Join(", ", arr) + "]");
}
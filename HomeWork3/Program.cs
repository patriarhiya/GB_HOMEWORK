Console.Clear();

//Необходимо выбрать задачу из файла Task3.txt ----------------------

int n = 4;
Console.Write($"Введите номер домашнего задания из {n}: ");
int number = int.Parse(Console.ReadLine());
while(number > n || number <= 0){
    Console.Write($"Такого номера нет. Введите номер домашнего задания из {n}: ");
    number = int.Parse(Console.ReadLine());
}


//Задача 1 ---------------------------------------------------------

if (number == 1){
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
while(a<10000 || a>99999){
    Console.WriteLine("Не пятизначное число. Введите заново: ");
    a = int.Parse(Console.ReadLine());
}
int a1 = a / 10000;
int a2 = a % 10000;
a2 /= 1000;
int a4 = a % 100;
a4 /= 10;
int a5 = a % 10;


if((a1 == a5)&&(a4 == a2)) Console.WriteLine($"число палиндром");
else Console.WriteLine("Не палиндром");

}

//Задача 2 ---------------------------------------------------------

if (number == 2){

Console.Write("Введите координаты первой точки и второй точки через пробел: ");

string? xyz = Console.ReadLine();
string[] split = xyz.Split(" ", StringSplitOptions.RemoveEmptyEntries);
while (split.Length > 6 || split.Length < 6){
    Console.WriteLine("Не удалось определеть 6 значений для двух координат");
    return;
}
int[] array = new int[6];
for (int i = 0; i < array.Length; i++){
    array[i] = Convert.ToInt32(split[i]);
}
double r = Math.Pow(array[3]-array[0], 2)+Math.Pow(array[4]-array[1], 2)+Math.Pow(array[5]-array[2], 2);
Console.WriteLine($"Расстояние между точками ({array[0]}, {array[1]}, {array[2]}) и ({array[3]}, {array[4]}, {array[5]}) = {Math.Sqrt(r)}");


}

//Задача 3 ---------------------------------------------------------

if (number == 3){

Console.Write("Введите число, больше нуля: ");
int a = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i < a; i++){
Console.WriteLine(Math.Pow(i, 3));
}

}

//Задача 4 ---------------------------------------------------------

if (number == 4){

int CountR (string strng){
    int r = 0;
    for(int i = 0; i < strng.Length; i++){
        if(strng[i] == ';'){
            r++;
        }
    }
    return r;
}
string[] ArrayR (string strng, int r){
    string[] array = new string[r];
    string s = "";
    int j = 0;
    for(int i = 0; i < strng.Length; i++){
        if(strng[i] != ';'){
            s = s+strng[i];
        }else{
            array[j] = s;
            j++;
            s = "";
        }
    }
    return array;
}
void ClearDubl(string[] array){
    int r = array.Length;
    bool dublicat = false;
    string[] newArray = new string[r];
    newArray[0] = array[0];
    int newR = 1;
    for(int i = 1; i < r; i++){
        for(int j = 0; j < newR; j++){
            if(array[i] == newArray[j]){
                dublicat = true;
            }
        }
        if(dublicat == false){
            newArray[newR] = array[i];
            newR++;
        }else{
            dublicat = false;
        }
    }
    Array.Resize(ref newArray, newR);
    Console.WriteLine($"Уникальных значений из {r} -> {newR}:");
    PrintArray(newArray);
}
void PrintArray (string[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"[{i+1}]={array[i]} ");
    Console.WriteLine();
}

Console.WriteLine("Введите слова через ; ");
string? inputS = Console.ReadLine();
int r = CountR(inputS);
string[] arrayS = ArrayR(inputS, r);
PrintArray(arrayS);
ClearDubl(arrayS);

}
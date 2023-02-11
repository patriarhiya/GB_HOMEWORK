Console.Clear();

//Необходимо выбрать задачу из файла Task.txt ----------------------

int n = 4;
Console.Write($"Введите номер домашнего задания из {n}: ");
int number = int.Parse(Console.ReadLine());
while(number > n || number <= 0){
    Console.Write($"Такого номера нет. Введите номер домашнего задания из {n}: ");
    number = int.Parse(Console.ReadLine());
}


//Задача 1 ---------------------------------------------------------

if (number == 1){
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
if(a == b){
    Console.Write("Число 1 равно числу 2");
}else if(a > b){
    Console.Write("Число 1 больше числа 2");
}else{
    Console.Write("Число 1 меньше числа 2");
}
}


//Задача 2 ---------------------------------------------------------

if (number == 2){
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine());
if(a < b){
    if(b < c){
        Console.Write("Максимальное число 3");
    }else{
        Console.Write("Максимальное число 2");
    }
}else{
    Console.Write("Максимальное число 1");
}
}


//Задача 3 ---------------------------------------------------------

if (number == 3){
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
a = a % 2;
if(a > 0){
    Console.Write("Введенное число нечетное");
}else{
    Console.Write("Введенное число четное");
}  
}


//Задача 4 ---------------------------------------------------------

if (number == 4){
Console.Write("Введите количество чисел: ");
int a = int.Parse(Console.ReadLine());  
for(int i = 2; i <= a; i += 2){
Console.Write(i + " ");
}
}
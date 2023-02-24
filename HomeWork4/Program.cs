Console.Clear();

//Необходимо выбрать задачу ---------------------------------------

int n = 3;
Console.Write($"Введите номер домашнего задания из {n}: ");
int number = int.Parse(Console.ReadLine());
while(number > n || number <= 0){
    Console.Write($"Такого номера нет. Введите номер домашнего задания из {n}: ");
    number = int.Parse(Console.ReadLine());
}


//Задача 1 ---------------------------------------------------------
/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

if (number == 1){

int MyPow (int a, int b){
    int result = a;
    for(int i = 0; i < b - 1; i++){
        result *= a;
    }
    return result;
}
Console.WriteLine("Введите число и степень поочереди: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число {a} в степени {b} равно {MyPow(a, b)}");

}

//Задача 2 ---------------------------------------------------------
/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

if (number == 2){

int Count(int a){
    int result = 0;
    int s = 1;
    int b = a;
    for(int i = 0; a > s - 1; i++){
        s *= 10;
        result += b % 10;
        b = b / 10;
    }
    return result;
}
int r = Convert.ToInt32(Console.ReadLine());
int s = Count(r);
Console.WriteLine(s);

}

//Задача 3 ---------------------------------------------------------
/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

if (number == 3){

void FillArray (int[] collection)
{
    for(int i = 0; i < collection.Length; i++){
        collection[i] = new Random().Next(0, 201);
        Console.Write($"[{i+1}]={collection[i]} ");
    } 
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine();

}
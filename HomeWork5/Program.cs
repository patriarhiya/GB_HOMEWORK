Console.Clear();

//Необходимо выбрать задачу ---------------------------------------

int n = 3;
Console.Write($"Введите номер домашнего задания из {n}: ");
int number = int.Parse(Console.ReadLine());
while(number > n || number <= 0){
    Console.Write($"Такого номера нет. Введите номер домашнего задания из {n}: ");
    number = int.Parse(Console.ReadLine());
}

int[] FillArray(int min, int max, int length){
    int[] array = new int[length];
    for(int i = 0; i < length; i++){
        array[i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
double[] FillArrayDouble(int length){
    double[] array = new double[length];
    for(int i = 0; i < length; i++){
        array[i] = new Random().NextDouble();
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

//Задача 1 ---------------------------------------------------------
/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

if (number == 1){

int EvenCount(int[] collection){
    int result = 0;
    foreach (var item in collection)
    {
        result += item % 2 == 0 ? 1 : 0;
    }
    return result;
}

int[] array = FillArray(100, 999, 10);
int count = EvenCount(array);
Console.WriteLine($"Количество четных чисел {count}");
}

//Задача 2 ---------------------------------------------------------
/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

if (number == 2){

int SumEvenIndex(int[] collection){
    int diff = 0;

    for(int i = 1; i < collection.Length; i += 2){
        diff += collection[i];
    }
    return diff;
}

int[] array = FillArray(-99, 99, 10);
int diff = SumEvenIndex(array);
Console.WriteLine($"Сумма четных позиций {diff}");

}

//Задача 3 ---------------------------------------------------------
/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

if (number == 3){

double DiffMaxMin(double[] collection){
    double diff, min, max;
    min = max = collection[0];
    foreach (var item in collection)
    {
        min = item < min ? item : min;
        max = item > max ? item : max;
    }
    Console.WriteLine($"min = {min} and max = {max}");
    diff = max - min;
    return diff;
}

double[] array = FillArrayDouble(10);
double diff = DiffMaxMin(array);
Console.WriteLine($"Разница между макс и мин {diff}");

}
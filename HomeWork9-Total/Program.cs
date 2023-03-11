using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

Clear();

//Необходимо выбрать задачу ---------------------------------------

int num = 3;
Write($"Введите номер домашнего задания из {num}: ");
int number = Convert.ToInt32(ReadLine());
while(number > num || number <= 0){
    Write($"Такого номера нет. Введите номер домашнего задания из {num}: ");
    number = Convert.ToInt32(ReadLine());
}

int[,] FillMatrixInt(int rows, int columns, int min, int max){
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = new Random().Next(min, max + 1);
        } 
    }
    return matrix;
}

double[,] FillMatrixDouble(int rows, int columns, int dec = 15){
    double[,] matrix = new double[rows, columns];
    for(int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble(), dec);
        }
    }
    return matrix;
}

int[] InputArrayInt(char sep = ' '){

string? xyz = ReadLine();
string[] split = xyz.Split(sep, StringSplitOptions.RemoveEmptyEntries);
WriteLine();
int[] result = new int[split.Length];
for(int i = 0; i < split.Length; i++){
result[i] = Convert.ToInt32(split[i]);
} 
return result;
}

double[] InputArrayDouble(char sep = ' '){

string? xyz = ReadLine();
string[] split = xyz.Split(sep, StringSplitOptions.RemoveEmptyEntries);
WriteLine();
double[] result = new double[split.Length];
for(int i = 0; i < split.Length; i++){
result[i] = Convert.ToDouble (split[i]);
} 
return result;
}

void PrintMatrixInt(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} ");
        }
        WriteLine();
    }
}

void PrintMatrixDouble(double[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} ");
        }
        WriteLine();
    }
}

void PrintArrayInt(int[] array){
    for(int i = 0; i < array.Length; i++){
            Write($"{array[i]} ");
    }
    WriteLine();
}

void PrintArrayDouble(double[] array){
    for(int i = 0; i < array.Length; i++){
            Write($"{array[i]} ");
    }
    WriteLine();
}

void PrintArrayString(string[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

//Задача 1 ---------------------------------------------------------
/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

if (number == 1){

void PrintNaturalNumbersMaxToMin(int n)
{ 
    if(n == 1){
        WriteLine($"{n}");
        return;
    }

    Write($"{n}, ");
    PrintNaturalNumbersMaxToMin(n-1);
}

int m = 8;
PrintNaturalNumbersMaxToMin(m);

}

//Задача 2 ---------------------------------------------------------
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

if (number == 2){

int SumNumberToNumber (int m, int n)
{   
    if(n == m){
        return m;
    }
    return m += SumNumberToNumber(m+1, n);
}

int m = 1, n = 15;
int sum = SumNumberToNumber(m, n);
Write(sum);



}

//Задача 3 ---------------------------------------------------------
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

if (number == 3){


int Akerman (int m, int n)
{   
    if(m == 0) return n + 1;
    else if(n == 0) return Akerman(m - 1, 1);
    else return Akerman(m - 1, Akerman(m, n - 1));
}

int m = 3, n = 2;
int aker = Akerman(m, n);
Write($"A(m,n) = {aker}");


}


using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

Clear();

//Необходимо выбрать задачу ---------------------------------------

int num = 5;
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
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

if (number == 1){

int[,] matrix = FillMatrixInt(3,4,0,9);
PrintMatrixInt(matrix);
WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if(matrix[i,k] < matrix[i, k+1]){
                int temp = matrix[i,k];
                matrix[i,k] = matrix[i, k+1];
                matrix[i,k+1] = temp;
            }
        }
    }
}

PrintMatrixInt(matrix);

}

//Задача 2 ---------------------------------------------------------
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

if (number == 2){

int[,] matrix = FillMatrixInt(5,5,0,9);
PrintMatrixInt(matrix);
WriteLine();

int line = 0;
int sumMax = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i,j];
    }
    if(sum > sumMax){
        sumMax = sum;
        line = i+1;
    }
}
WriteLine(line);
}

//Задача 3 ---------------------------------------------------------
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

if (number == 3){

int[,] matrix1 = FillMatrixInt(3,3,0,9);
int[,] matrix2 = FillMatrixInt(3,3,0,9);

PrintMatrixInt(matrix1);
WriteLine();
PrintMatrixInt(matrix2);
WriteLine();

int[,] matrixResult = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(0); k++)
        {
            matrixResult[i,j] += matrix1[i,k] * matrix2[k,j];
        }
    }
}
PrintMatrixInt(matrixResult);
WriteLine();
}

//Задача 4 ---------------------------------------------------------
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

if (number == 4){

int m, o, p;
m = o = p = 4;
int[,,] matrix = new int[m, o, p];

int[] line = new int[m * o * p];

bool nonUnique;
int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            int n = 0;
            nonUnique = true;
            while(nonUnique){
                n = new Random().Next(10,100);
                for (int l = 0; l <= count; l++)
                {
                    if(n != line[l]){
                        nonUnique = false;
                    }else{
                        nonUnique = true; 
                        break;
                    }
                }
            }
            matrix[i,j,k] = n;
            line[count] = n;
            count++;

        }
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Write($"{matrix[i,j,k]}({i},{j},{k}) ");
        }
        WriteLine();
    }
    WriteLine();
}

}

//Задача 5 ---------------------------------------------------------
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 
Реализован ввод квадратной матрицы.
*/

if (number == 5){


Write("Введите размер квадратной матрицы: ");
int t = Convert.ToInt32(ReadLine());
int[,] matrix = new int[t,t];
int value = 11;
int cycle = t;

int n = 0;
while(t>2){


for (int i = n; i < t; i++)
{
    matrix[n, i] = value;
    WriteLine($"[{n},{i}] = {value}");
    value++;
}
for (int i = n+1; i < t; i++)
{
    matrix[i, t-1] = value;
    WriteLine($"[{i},{t-1}] = {value}");
    value++;
}
for (int i = t-2; i+1 > n; i--)
{
    matrix[t-1, i] = value;
    WriteLine($"[{t-1},{i}] = {value}");
    value++;
}
for (int i = t-2; i > n; i--)
{
    matrix[i, n] = value;
    WriteLine($"[{i},{n}] = {value}");
    value++;
}
t--;
n++;


}

PrintMatrixInt(matrix);

}
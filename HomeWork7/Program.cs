using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

Clear();

//Необходимо выбрать задачу ---------------------------------------

int num = 4;
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
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

if (number == 1){

PrintMatrixDouble(FillMatrixDouble(3,4,2));

}


//Задача 2 ---------------------------------------------------------
/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

if (number == 2){

int[,] matrix = FillMatrixInt(3,4,0,9);
PrintMatrixInt(matrix);
Write("Введите индекс в двумерном массиве через запятую без пробела: ");
int[] index = InputArrayInt(',');
if(index.Length < 2){
    Write("Индекс содержит менее 2 чисел");
    WriteLine();
    return;
    }else{Array.Resize(ref index, 2);
}
int x = index[0];
int y = index[1];
if(x > matrix.GetLength(0) || y > matrix.GetLength(1)){
    Write("Такого индекса нет");
}else{
    Write($"Число с позицией {x},{y} = {matrix[x-1,y-1]}");
}
WriteLine();

}

//Задача 3 ---------------------------------------------------------
/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

if (number == 3){

double[] AverageArrayColumns(int [,] matrix){
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j,i];
        }
        result[i] /= matrix.GetLength(0);
        result[i] = Math.Round(result[i], 1);
    }
    return result;
}

int[,] matrix = FillMatrixInt(3,4,0,9);
PrintMatrixInt(matrix);
PrintArrayDouble(AverageArrayColumns(matrix));

}

//Задача 4 ---------------------------------------------------------
/*
Место действия этой игры – «вселенная» – это размеченная на клетки поверхность.
Каждая клетка на этой поверхности может находиться в двух состояниях: быть живой или быть мертвой.
Клетка имеет восемь соседей. Распределение живых клеток в начале игры называется первым поколением.
Каждое следующее поколение рассчитывается на основе предыдущего по таким правилам:
1)пустая(мертвая) клетка с ровно тремя живыми клетками-соседями оживает;
2)если у живой клетки есть две или три живые соседки, то эта клетка продолжает жить;
в противном случае (если соседок меньше двух или больше трех) 
клетка умирает(от «одиночества» или от «перенаселенности»).
В этой задаче рассматривается игра «Жизнь» на торе. 
Представим себе прямоугольник размером n строк на m столбцов. 
Для того, чтобы превратить его в тор мысленно «склеим» его верхнюю сторону с нижней, а левую с правой.
Таким образом, у каждой клетки, даже если она раньше находилась на границе прямоугольника,
теперь есть ровно восемь соседей.
Ваша задача состоит в том, чтобы найти конфигурацию клеток, которая будет через k поколений от заданного.
n m k(4 ≤ n, m ≤ 100; 0 ≤ k ≤ 100).

5		++...		.+.++
5		..++.		+.+..
1		.+...		.+.+.
		..+..		..+..
		...+.		.++..

5		++...		.+++.
5		..++.		.+...
5		.+...		.+...
		..+..		..++.
		...+.		.....

4		.+.+.+.		.......
7		+.+.+.+		.......
5		.+.+.+.		.......
		+.+.+.+		.......
*/

if (number == 4){

Write("Введите количество строк: ");
int n = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов: ");
int m = Convert.ToInt32(ReadLine());

string[,] FillTerra(int n, int m){
/*    string [,] matrix = {
        {".","+",".","+",".","+","."},
        {"+",".","+",".","+",".","+"},
        {".","+",".","+",".","+","."},
        {"+",".","+",".","+",".","+"}
    };
*/
/*    string [,] matrix = {
        {"*","*",".",".","."},
        {".",".","*","*","."},
        {".","*",".",".","."},
        {".",".","*",".","."},
        {".",".",".","*","."}
    };
*/
    string [,] matrix = new string [n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int k = new Random().Next(0,2);
            matrix[i,j] = k > 0 ? "*" : ".";
        }
    }

    return matrix;
}

string[,] terra = FillTerra(n, m);

PrintArrayString(terra);

string LiveOrDie(int i, int j, string[,] matrix){
    int r_index = matrix.GetLength(0) - 1;
    int c_index = matrix.GetLength(1) - 1;
    string[] line = new string[8];
    if(j+1>c_index) line[0] = matrix[i,0];
    else line[0] = matrix[i,j+1];
    if(j-1<0) line[1] = matrix[i,c_index];
    else line[1] = matrix[i,j-1];
    if(i+1>r_index) line[2] = matrix[0,j];
    else line[2] = matrix[i+1,j];
    if(i-1<0) line[3] = matrix[r_index,j];
    else line[3] = matrix[i-1,j];
    if(i-1<0 && j+1>c_index) line[4] = matrix[r_index,0];
    else if(i-1<0) line[4] = matrix[r_index,j+1];
    else if(j+1>c_index) line[4] = matrix[i-1,0];
    else line[4] = matrix[i-1,j+1];
    if(i+1>r_index && j+1>c_index) line[5] = matrix[0,0];
    else if(i+1>r_index) line[5] = matrix[0,j+1];
    else if(j+1>c_index) line[5] = matrix[i+1,0];
    else line[5] = matrix[i+1,j+1];
    if(i+1>r_index && j-1<0) line[6] = matrix[0,c_index];
    else if(i+1>r_index) line[6] = matrix[0,j-1];
    else if(j-1<0) line[6] = matrix[i+1,c_index];
    else line[6] = matrix[i+1,j-1];
    if(i-1<0 && j-1<0) line[7] = matrix[r_index,c_index];
    else if(j-1<0) line[7] = matrix[i-1,c_index];
    else if(i-1<0) line[7] = matrix[r_index,j-1];
    else line[7] = matrix[i-1,j-1];
 //   Write(string.Join(' ', line));
 //   WriteLine();
    
    
    int count = 0;
    for (int k = 0; k < 8; k++) if(line[k] == "*") count++;

    string result;
    if((matrix[i,j] == "*" && (count == 2 || count == 3)) || (matrix[i,j] == "." && count == 3)){
        result = "*";
    }else{
        result = ".";
    }
    return result;
}

string[,] ChangeTerra(string[,] matrix){
    string[,] result = new string[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i,j] = LiveOrDie(i, j, matrix);
        }
    }
    return result;
}

Write("Введите количество поколений: ");
int k = Convert.ToInt32(ReadLine());
for (int i = 0; i < k; i++)
{
    WriteLine($"Поколение {i+1}:");
    terra = ChangeTerra(terra);
    PrintArrayString(terra);
    Sleep(1600);
}

}
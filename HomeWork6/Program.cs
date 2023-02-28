Console.Clear();

//Необходимо выбрать задачу ---------------------------------------

int n = 2;
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

int[] InputArrayInt(char sep){

string? xyz = Console.ReadLine();
string[] split = xyz.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine();
int[] result = new int[split.Length];
for(int i = 0; i < split.Length; i++){
result[i] = Convert.ToInt32(split[i]);
} 
return result;
}

double[] InputArrayDouble(char sep){

string? xyz = Console.ReadLine();
string[] split = xyz.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine();
double[] result = new double[split.Length];
for(int i = 0; i < split.Length; i++){
result[i] = Convert.ToDouble (split[i]);
} 
return result;
}

//Задача 1 ---------------------------------------------------------
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

if (number == 1){

Console.WriteLine($"Введите числа через пробел: ");
int[] array = InputArrayInt(' ');

int count = 0;
for (int i = 0; i < array.Length; i++) count += array[i] > 0 ? 1 : 0;
Console.WriteLine(count);

}

//Задача 2 ---------------------------------------------------------
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

if (number == 2){

Console.WriteLine($"Введите четыре числа через пробел: ");
double[] array = InputArrayDouble(' ');
while(array.Length != 4){
    Console.WriteLine($"Введите четыре числа через пробел: ");
    array = InputArrayDouble(' ');
}

// b1 = 0, k1 = 1, b2 = 2, k2 = 3
// уравнения y = k1 * x + b1, y = k2 * x + b2
// значит k1 * x + b1 = k2 * x + b2 или x = (b2-b1)/(k1-k2)
double x = (array[2] - array[0]) / (array[1] - array[3]);
double y = array[1] * x + array[0];

Console.WriteLine($"({x};{y})");


}

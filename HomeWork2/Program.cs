Console.Clear();

//Необходимо выбрать задачу из файла Task2.txt ----------------------

int n = 4;
Console.Write($"Введите номер домашнего задания из {n}: ");
int number = int.Parse(Console.ReadLine());
while(number > n || number <= 0){
    Console.Write($"Такого номера нет. Введите номер домашнего задания из {n}: ");
    number = int.Parse(Console.ReadLine());
}

//Задача 1 ---------------------------------------------------------

if (number == 1){

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

while(a < 100 || a > 999)
{
    Console.Write("Внимательнее! Введите трехзначное число: ");
    a = int.Parse(Console.ReadLine());
}
a /= 10;
a %= 10;
Console.Write(a);

}


//Задача 2 ---------------------------------------------------------

if (number == 2){

Console.Write("Введите любое натуральное число до 1 000 000 000: ");
int a = int.Parse(Console.ReadLine());
while(a < 1 || a > 1000000000)
{
    Console.Write("Введите любое натуральное число до 1 000 000 000: ");
    a = int.Parse(Console.ReadLine());
}
if(a<100) Console.WriteLine("У числа нет третьей цифры");
else 
{
    while(a > 999)
    {
        a /= 10;
    }
    Console.WriteLine(a %= 10);
}

}


//Задача 3 ---------------------------------------------------------

if (number == 3){

Console.Write("Введите день недели: ");
int a = int.Parse(Console.ReadLine());

while(a < 1 || a > 7)
{
    Console.Write("Внимание! Введите день недели: ");
    a = int.Parse(Console.ReadLine());
}
if(a < 6) Console.Write("Будний день>");
else Console.Write("Выходной день>");

}

//Задача 4 ---------------------------------------------------------

if (number == 4){
//Сначала методы Заполнения, Печати и Сортировки
void FillArray (int[] collection)
{
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(100, 201);
}
void PrintArray (int[] collection)
{
    for(int i = 0; i < collection.Length; i++) Console.Write($"[{i+1}]={collection[i]} ");
}
void SortArray (int[] collection)
{
    
    for(int i = 0; i < collection.Length - 1; i++)
    {
        int buf;
        for(int ind = 0; ind < collection.Length - 1; ind++)
        {
            if(collection[ind]<collection[ind+1])
            {
                buf = collection[ind];
                collection[ind] = collection[ind+1];
                collection[ind+1] = buf;
            }
        }
    }
}

//Указали рандомное значение размера массива, заполнили и отсортировали массив
//Вывод номер в шеренге = рост 
int r = new Random().Next(5, 101);
int[] array = new int[r];
Console.WriteLine();
Console.WriteLine($"Всего учеников {r}, со следующими показателями роста");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
SortArray(array);
Console.WriteLine($"А теперь в порядке невозрастания от {array[0]} до {array[r-1]}");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

//рандомное значение роста Пети. и определяем позицию, где рост Пети будет больше
//Это и будет его место, даже если перед ним будут ребята с одинаковым ростом.
int petya = new Random().Next(100, 201);

Console.WriteLine($"Рост Пети {petya} см");

for(int i = 0; i < r; i++)
{
    if(array[i] < petya)
    {
        Console.Write($"Место в шеренге для Пети -> {i+1}");
        Console.WriteLine();
        break;
    }
}

}
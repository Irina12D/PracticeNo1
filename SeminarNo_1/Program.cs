/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
          какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
*/

/*
Console.Write("введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("введите второе число ");
int b = int.Parse(Console.ReadLine());

if(a > b)
    Console.WriteLine($"max = {a}, min = {b}");
else if (b > a)
    Console.WriteLine($"max = {b}, min = {a}");    
    else 
    Console.WriteLine("значения чисел равны");
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа
          и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/

/*
Console.Write("введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("введите второе число ");
int b = int.Parse(Console.ReadLine());

Console.Write("введите третье число ");
int c = int.Parse(Console.ReadLine());

//вложенные простые условия
if (a > b)
    if(a > c)
        Console.WriteLine(a);
    else
        Console.WriteLine(c);
else
    if(b > c)
        Console.WriteLine(b);
    else
        Console.WriteLine(c);                

// составные условия - логические операции
if (a > b && a > c)
        Console.WriteLine(a);
else
    if (b > a && b > c)
        Console.WriteLine(b);
else
    Console.WriteLine(c); 

// встроенная функция Max()
Console.WriteLine(Math.Max(a, Math.Max(b,c)));
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
          является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
*/

/*
Console.Write("введите число ");
int x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
    Console.WriteLine($"число {x} - чётное");
else 
    Console.WriteLine($"число {x} - нечётное");    
*/


/*
Задача 8: Напишите программу, которая на вход принимает число (N),
          а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
*/
Console.Write("введите число ");
int N = int.Parse(Console.ReadLine());
int count = 2;
while(count <= N)
{
    Console.Write($"{count} ");
    count += 2;
}






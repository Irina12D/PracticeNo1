/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
          какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
*/

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



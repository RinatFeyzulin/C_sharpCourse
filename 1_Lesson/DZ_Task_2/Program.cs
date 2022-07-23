// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("max = ");
if(a>b)
    Console.WriteLine(a);
else
    Console.WriteLine(b);

    Console.WriteLine("min = ");
if(a<b)
    Console.WriteLine(a);
else
    Console.WriteLine(b);
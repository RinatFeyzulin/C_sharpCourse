﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Write a number: ");
int a=int.Parse(Console.ReadLine());

void Quarters(int n)
{
for(int i=1;i<=n;i++)
{
   Console.WriteLine(Math.Pow(i, 3));
}
}

Quarters(a);

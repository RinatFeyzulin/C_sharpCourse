// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(n%10);


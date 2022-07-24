// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Method (int a)
{
    int n1 = a/10;
    int n2=n1%10;
    Console.WriteLine($"{n2} Второе число");
}

Console.WriteLine("Введите трехзначное число: ");
int a=int.Parse(Console.ReadLine());

Method(a);


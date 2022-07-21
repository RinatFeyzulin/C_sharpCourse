// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Write a number a: ");
int a=int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b=int.Parse(Console.ReadLine());

if(a*a==b)
{
  Console.WriteLine("Yes");  
}

else
{
    Console.WriteLine("No");
}




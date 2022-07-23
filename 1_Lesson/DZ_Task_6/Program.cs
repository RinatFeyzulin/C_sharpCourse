// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

if(n%2==0)
    Console.WriteLine("Число является четным");
else
    Console.WriteLine("Число является  не четным");



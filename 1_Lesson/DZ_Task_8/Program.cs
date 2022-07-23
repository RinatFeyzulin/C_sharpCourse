// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

int i=2;

while(n>=i)
{
Console.WriteLine(i);
i=i+2;
}

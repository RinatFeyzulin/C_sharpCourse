// 4. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

void Method (int a)
{
    if(a % 7 == 0 & a % 23 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine("Не кратно");
}

Console.WriteLine("Write a number: ");
int a=int.Parse(Console.ReadLine());

Method(a);

// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

void number(int a)
{
   string num = a.ToString();
   Console.WriteLine(num.Length);
}

number(654345);

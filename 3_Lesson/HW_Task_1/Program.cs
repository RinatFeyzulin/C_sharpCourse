// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Write a number: "); 
string a = Console.ReadLine();


void res (string a)
{
if (a[0]==a[4] && a[1]==a[3])
Console.WriteLine("является палинромом");
else 
Console.WriteLine("error");
}
res(a);
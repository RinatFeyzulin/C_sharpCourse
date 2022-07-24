// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int a=int.Parse(Console.ReadLine());

string WeekDayOff(int Num) 
{
    if(Num == 7) return ("Выходной");
    if(Num == 6) return ("Выходной");
    else return ("Не выходной");
}


Console.WriteLine(WeekDayOff(a));

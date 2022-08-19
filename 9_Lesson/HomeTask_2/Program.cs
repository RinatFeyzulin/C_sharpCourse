// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumSum(int m,int n)
{
    if(n<m)return 0;
    return NumSum(m,n-1)+n;
}
Console.WriteLine(NumSum(1,15));

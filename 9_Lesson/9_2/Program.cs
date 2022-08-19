// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void ValueSet(int n, int m)
{
    if(n > m) return;
    ValueSet(n,m-1);
    Console.Write($"{m} ");
}
ValueSet(4,8);

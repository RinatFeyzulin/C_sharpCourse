﻿// Задача 3: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonnachi(int n)
{
    int f=0;
    int f1=1;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{f} ");
        (f,f1) = (f1,f+f1);//Кортеж))
    }
}

Fibonnachi(9);
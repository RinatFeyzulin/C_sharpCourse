//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int exponentiate(int a, int b)
{
    int result = a;
    for(int i = 1;i<b; i++)
    {
        result = a*result;
    }

    return result;
}

Console.WriteLine(exponentiate(4,5));
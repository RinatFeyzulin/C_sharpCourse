// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

int Number(int a)
{
    int result = 1;
    for(int i = 1; i<=a; i++)
    {
       result=i*result;
    }

    return result;
}

Console.WriteLine(Number(5));
// 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

void dreiAngle(int x, int y, int z)
{
    if(x+y>z && x+z>y && z+y>x) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

dreiAngle(1,2,3);

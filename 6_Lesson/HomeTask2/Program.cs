// 2: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


// y = k1 * x + b1, y = k2 * x + b2;     
// k1*x+b1 = k2*x+b2
// k1*x-k2*x=b2-b1
// x(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)

void intersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.Write($"{x}, {y} - пересечение двух прямых");

}

intersectionPoint(2,3,3,2);


// y = 2 * x + 3, y = 3 * x + 2;
// 2x-3x = 2-3;
// -x=-1
// x=1
//y1=2*1+3=5
//y2=3*1+2=5


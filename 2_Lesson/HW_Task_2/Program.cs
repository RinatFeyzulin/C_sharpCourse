// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int DeleteTwoNum(int Num) 
{
    int n1 = Num/100;
    int n2=  Num%10;
    Console.WriteLine($"{n1}{n2}");
    return Num;
}

Console.WriteLine(DeleteTwoNum(new Random() .Next(100,1000)));




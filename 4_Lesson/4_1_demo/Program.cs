//Задача 1: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int sum(int a)
{
    
    int all_sum=0;
    for(int i=1;i<=a;i++)
    {
        all_sum = all_sum + i;
    }

 return all_sum;
}


Console.WriteLine(sum(4));
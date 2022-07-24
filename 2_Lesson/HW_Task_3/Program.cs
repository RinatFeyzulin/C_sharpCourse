// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int a=int.Parse(Console.ReadLine());

int DeleteNum(int Num) 
{
    while(Num>=1000)
    {
        int result = Num/10;
        Num=result;
    }
    int res=Num%10;
    return res;
}

if(a<100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(DeleteNum(a));

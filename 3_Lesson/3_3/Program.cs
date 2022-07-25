// Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

void Quarters(int n)
{
for(int i=1;i<=n;i++)
{
   Console.WriteLine(Math.Pow(i, 2));
}
}

Quarters(5);
// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string transformation(int n)
{
   string result = " ";
   while (n>0)
   {
    result =n%2 + result;
    n = n/2; 
   }
   return result;
}

Console.WriteLine(transformation(6));
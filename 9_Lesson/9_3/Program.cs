// 3. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.
int ValueSum(int n)
{
    if(n==0) return 0;
    return ValueSum(n/10)+n%10;
}
Console.WriteLine(ValueSum(228));
// Задача 2. Зайдайте массив. напишите программу,котора
// определяет, присутствует ли заданное число в массиве.

int [] myArray = {1,44,4,6,77,5,34,3,2,0,89,54,-3};
void ArrayEnumeration(int [] arr)
{
    Console.WriteLine("Write a number");
    int n = int.Parse(Console.ReadLine());
    string flag = "no";
    for (int i = 0; i < arr.Length; i++)
    {
        if(n == arr[i])
        {
            flag = "yes";
            break;
        }
    }
    Console.WriteLine(flag);
}
ArrayEnumeration(myArray);

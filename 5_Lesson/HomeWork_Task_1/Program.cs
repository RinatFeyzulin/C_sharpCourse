// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr = new int [10];
Random random = new Random();
void arrRandom(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100,999);
}

}

void evenCount(int []arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0) count+=1;
    }
    Console.Write($"{count} - Количество четных числе в массиве");
}

void Print()
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

arrRandom(arr);

evenCount(arr);

Print();
// задача 1. Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.


int [] arr = new int [12];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(-9,9);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}

void sumPozNeg(int []arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=0)
        pos+=arr[i];
        else neg+=arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Possitiv ={pos}, Negative{neg}");
}

sumPozNeg(arr);
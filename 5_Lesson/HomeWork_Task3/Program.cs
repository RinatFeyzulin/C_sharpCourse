// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] arr = new int [10];
Random random = new Random();
void arrRandom(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100);
}

}

int maxArray(int[]arr)
{
    int i = 0;
    int max = arr[i];
    for (; i < arr.Length; i++)
    {
        if(max<arr[i]) max = arr[i];
    }

 return max;
}

int minArray(int[]arr)
{
    int i = 0;
    int min = arr[i];
    for (; i < arr.Length; i++)
    {
        if(min>arr[i]) min = arr[i];
    }

 return min;
}

void differenceMaxMin(int []arr)
{
    int resultDifference = maxArray(arr) - minArray(arr); 
    Console.Write($"{resultDifference} - разница");
}

void Print()
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

arrRandom(arr);

differenceMaxMin(arr);

Print();
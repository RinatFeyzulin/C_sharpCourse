// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 0

int [] arr = new int [10];
Random random = new Random();
void arrRandom(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(10);
}

}

void oddPosition(int []arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2==1) sum+=arr[i];
    }
    Console.Write($"{sum} - Сумма элементов нечетных позиций");
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

oddPosition(arr);

Print();
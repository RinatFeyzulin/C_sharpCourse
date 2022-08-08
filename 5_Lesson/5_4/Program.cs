
// Задача 4: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] arr = new int [7];
Random random = new Random();
void arrRandom(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(15);
}
}

    
void ProductOfNumbers(ref int []arr)
{
    int j=arr.Length -1;
    int [] myArray = new int[arr.Length/2 + arr.Length % 2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        myArray[i] = arr[i] * arr[j];
        j--;
    }
    if(arr.Length % 2 == 1)
    myArray[^1] = arr[(arr.Length/2 + arr.Length % 2)-1];
    arr = myArray;
}

void Print()
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}  ");
} 
Console.WriteLine();
}


arrRandom(arr);
Print();
ProductOfNumbers(ref arr);
Print();


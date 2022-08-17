// Задача 2: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Print(int [,]arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j <columnSize; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ArrayRandom(int row, int column)
{
   int [,]arr = new int[row,column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <column; j++)
        {
            arr[i,j] = new Random().Next(1,10); 
        }
    }
    return arr;
}

void MinSum(int [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[]myArray = new int[row];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           myArray[i] = sum+=arr[i,j];
        }
    }
    int indexMinSum = Array.IndexOf( myArray, myArray.Min());
    Console.WriteLine($"Программа считает что наименьшая сумма элементов массива на {indexMinSum+1} строке");
}


int [,] myArray = ArrayRandom(6,4);
Print(myArray);

Console.WriteLine();

MinSum(myArray);

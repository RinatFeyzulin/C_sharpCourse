// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


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

int [,] ArraySort(int [,] arr)
{
  
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
     for (int i = 0; i <column; i++)
    {
        for(int k=0;k<column-1;k++)
        {
        int minPos0=i;
        int minPos1=0;
        for (int j = 1; j < column; j++)
        { 
            if(arr[i,j]>arr[minPos0,minPos1])
            {
                minPos1=j;
            }
        int vedro1 = arr[i,j];
        arr[i,j] = arr[minPos0,minPos1];
        arr[minPos0,minPos1]=vedro1;
        }
        }
    }
    return arr;
}


int [,] myArray = ArrayRandom(6,6);
Print(myArray);

Console.WriteLine();

ArraySort(myArray);
Print(myArray);
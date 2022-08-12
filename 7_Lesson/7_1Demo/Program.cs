// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

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


int [,] ArrayNum(int row, int column, int from, int to)
{
   int [,]arr = new int[row,column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <column; j++)
        {
            arr[i,j] = new Random().Next(from,to); 
        }
    }
    return arr;
}

int [,] myArray = ArrayNum(3,5,1,100);
Print(myArray);
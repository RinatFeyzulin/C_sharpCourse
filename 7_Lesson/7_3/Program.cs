// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12

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


int [,] ArrayNum(int row, int column)
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

int  sumDiagonalmyArray(int[,]arr)
{
   int sumDiagonal = 0;
    for (int i = 0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            if(i==j) sumDiagonal+=arr[i,j];
        }
    }
    return sumDiagonal;
}
int [,] myArray = ArrayNum(3,3);
Print(myArray);

Console.WriteLine($"Sum {sumDiagonalmyArray(myArray)}");


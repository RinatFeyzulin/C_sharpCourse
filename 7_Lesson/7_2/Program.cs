// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2  
// 5 9 2 3
// 8 4 2 4

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

int [,] ArrayKvadrat(int [,]arr)
{

    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j <arr.GetLength(1); j+=2)
        {
            arr[i,j] *= arr[i,j];
        }
    }
    return arr;
}


int [,] myArray = ArrayNum(5,5,1,10);
Print(myArray);
Console.WriteLine("++++++++++");
Console.WriteLine();
ArrayKvadrat(myArray);
Print(myArray);
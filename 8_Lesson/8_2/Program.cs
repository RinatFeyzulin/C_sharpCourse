// Задача 2: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int [,] Average(int [,] arr)
{
  
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int [,] arrAverage = new int [row,column];

    for (int i = 0; i <row; i++)
    {
        for (int j = 0; j < column; j++)
    {        
        (arrAverage[i, j]) = ( arr[j,i]);        
    
    }
    }
    
    return arrAverage;
}

int [,] myArray = ArrayRandom(4,4);
Print(myArray);

Console.WriteLine();

Print(Average(myArray));
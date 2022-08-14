// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print(double [,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j <columnSize; j++)
        {
            Console.Write($" {arr[i, j], 6} |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] arrRandomNumber(double[,]arr,int row, int column)

{
   double [,]arrResult = new double[row,column];
   Random random = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <column; j++)
        {
            arr[i,j] = Math.Round(random.NextDouble()*(10+20)-10,2); 
        }
    }
    return arrResult;
}

double [,] myArray = new double[5,5];

arrRandomNumber(myArray,5,5);
Print(myArray);
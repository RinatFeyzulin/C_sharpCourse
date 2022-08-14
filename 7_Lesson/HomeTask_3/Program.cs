// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintOneDimenciomalArray(double []arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
     Console.Write($"{arr[i]}  ");
    }
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

double [] Average(int [,] arr)
{
  
    double [] countGetLenghtArr = new double[arr.GetLength(1)];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
              for (int j = 0; j <arr.GetLength(1); j++)
            {
                countGetLenghtArr[j]=countGetLenghtArr[j] + arr[i,j];
            }      
        }

        for (int i = 0; i < arr.GetLength(1); i++)
        {
                countGetLenghtArr[i]=countGetLenghtArr[i] /arr.GetLength(0); 
        }
    
    return countGetLenghtArr;
}

int [,] myArray = ArrayRandom(5,6);
Print(myArray);

double [] averageArray = Average(myArray);
PrintOneDimenciomalArray(averageArray);
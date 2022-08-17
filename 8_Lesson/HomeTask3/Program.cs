// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int [,] MultiplicationMatrix(int [,] arr1, int [,] arr2)
{
    int row = arr1.GetLength(0);
    int column = arr1.GetLength(1);
    int[,]myArray3 = new int[row,column];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
           myArray3[i,j] = arr1[i,j]*arr2[i,j];
        }
    }
    return myArray3;
}


int [,] myArray1 = ArrayRandom(5,5);
int [,] myArray2 = ArrayRandom(5,5);
Print(myArray1);
Print(myArray2);

Print(MultiplicationMatrix(myArray1,myArray2));





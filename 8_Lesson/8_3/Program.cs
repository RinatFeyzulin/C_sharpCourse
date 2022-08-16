// Задача 4: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


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

int [] MinSearch (int [,] array) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1); 
    int min = array[0,0]; 
    int [] index = new int [2]; 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            if (min > array [i,j]) 
            { 
                min = array [i,j]; 
                index [0] =i; 
                index [1] =j; 
            } 
        } 
         
    } 
    return index; 
} 
 
void DeleteRowColumn (int [,] array, int  [] index) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1); 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            if (index [0] == i || index [1] == j) 
            { 
                continue; 
            } 
            else 
            { 
                Console.Write($" {array[i, j]} "); 
            } 
        } 
        Console.WriteLine (); 
    } 
} 

int [,] myArray = ArrayRandom(4,4);
Print(myArray);

Console.WriteLine();

int [] new_arr = MinSearch (myArray); 
DeleteRowColumn (myArray, new_arr);


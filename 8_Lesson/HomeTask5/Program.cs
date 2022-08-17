// Задача 4. **
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Результат записать в новый массив и вывести

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
 
int [,] DeleteRowColumn (int [,] array, int  [] index) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1);
    int [,] arr_new = new int[row_size-1,column_size-1];

    for (int i = 0,q=0; i < row_size; i++,q++) 
    { 
        for (int j = 0,k=0; j < column_size; j++,k++) 
        { 
            if (index [0] == i)
            {
                if(i==2&&q==1)continue;
                if(i==1&&q==0)continue;
                if(i==1&&q==-1)++q;
                else if(q>=0)q--; 
                else continue;
            } 
            
            else if (index [1] == j)
            {
                if(k>0)--k;
                else continue;
            }
            else 
            { 
                if (index [1] == 0&&k==1&&j==1)k=0;
                arr_new[q,k] = array[i,j]; 
            } 
        } 
    } 
    return arr_new;
} 

int [,] myArray = ArrayRandom(4,4);
Print(myArray);

Console.WriteLine();

int [] new_arr = MinSearch (myArray); 
int [,] myArray2 = DeleteRowColumn (myArray, new_arr);
Print(myArray2);
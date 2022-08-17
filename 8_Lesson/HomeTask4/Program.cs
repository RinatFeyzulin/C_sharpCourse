// Задача 3: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Значения элементов массива 0..9

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

int [] DistinctToArray(int [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int [] array = new int[row*column];
    int k =0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[k]=arr[i,j];
            k++;
        }
    }
    return array.Distinct().ToArray();
}

void Counter(int [,] arr, int []arrDis)
{
    int rowArr = arr.GetLength(0);
    int column = arr.GetLength(1);
    int rowArrDis = arrDis.Length;
    
    for (int k = 0; k < rowArrDis; k++)
    {
        int count = 0;
        for (int i = 0; i < rowArr; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if(arr[i,j]==arrDis[k])count++;
            }
        }
        Console.WriteLine($"число {arrDis[k]} встречается - {count} раз");
    }

    
}
void printing(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int [,] myArray = ArrayRandom(3,3);
Print(myArray);

int [] distArray = DistinctToArray(myArray);
printing(distArray);
Console.WriteLine();

Counter(myArray,distArray);

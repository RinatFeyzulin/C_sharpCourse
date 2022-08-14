// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string findElementAtPosition(int[,]arr,int GetLength0, int GetLength1)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
                if(GetLength0-1 == i && GetLength1-1 == j ) 
                return $" На позиции {GetLength0} , {GetLength1} находится число {arr[GetLength0-1,GetLength1-1]}";
        }
    }
    return "Такой позиции в массиве нет";
}

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

int [,] myArray = ArrayRandom(5,5);
Print(myArray);


Console.WriteLine("Введите позицию в строке");
int firstPosition = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер строки");
int secondPosition = int.Parse(Console.ReadLine());


Console.WriteLine(findElementAtPosition(myArray,firstPosition,secondPosition));
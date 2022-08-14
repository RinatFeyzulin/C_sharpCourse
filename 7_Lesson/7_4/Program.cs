// Задача 4: Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

string FindingAnElement(int[,]arr,int n)
{
    string elementIndexResult = "Такого элемента нет";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            if(arr[i,j] == n) 
            {  
                indexI = i+1;
                indexJ = j+1;
                elementIndexResult = "число находится на позиции "  + indexI + ","  +  indexJ;
                return elementIndexResult;
            } 
        }
    }
    return elementIndexResult;
}

int [,] myArray = ArrayRandom(3,4);
Print(myArray);

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Wtite Number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(FindingAnElement(myArray,number));
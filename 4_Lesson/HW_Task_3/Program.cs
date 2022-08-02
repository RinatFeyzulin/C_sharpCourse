// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ArrRandom(ref int [] myArray)
{
    Random random = new Random();
    for(int i = 0;i<myArray.Length;i++)
    {
        myArray[i]= random.Next(100);
    }
}

void conclusion(ref int[] myArray)
{
    for(int i =0; i<myArray.Length;i++)
    {
        Console.Write($"{myArray[i]}  ");
    }
}

int [] myArray = new int[8];
ArrRandom(ref myArray);
conclusion(ref myArray);


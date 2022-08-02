// Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.



void ArrRandom()
{
    Random random = new Random();
    int [] myArray = new int[8];
    for(int i = 0;i<myArray.Length;i++)
    {
        myArray[i]= random.Next(0,2);
    }

    for(int i = 0;i<myArray.Length;i++)
    {
        Console.Write(myArray[i]);
    }
}

ArrRandom();
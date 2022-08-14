// 3: Напишите программу, которая будет создавать копию заданного массива
// (вещественные числа) с помощью поэлементного копирования.

double [] myArray=null;
double [] myArrCopy=null;

double [] arrRandom(int size, ref double []arr)
{
    Random random = new Random();
    arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(random.NextDouble()*(10+20)-10,2);
    }
    return arr;
}

double [] arrCopy(double [] arr, ref double[] ArrayCopy)
{
     ArrayCopy = new double[arr.Length];
     for (int i = 0; i < arr.Length; i++)
    {
        ArrayCopy[i] = arr[i];
    }
    return ArrayCopy;
}

void Print(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

arrRandom(10,ref myArray);
Print(myArray);

Console.WriteLine();

arrCopy(myArray,ref myArrCopy);
Print(myArrCopy);

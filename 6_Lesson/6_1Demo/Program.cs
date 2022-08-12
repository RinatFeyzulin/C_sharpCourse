// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
arr[i] = new Random().Next(from, to);
}
return arr;
}

int [] arrRev(int [] arr)
{
    int size = arr.Length - 1;
    for (int i = 0; i < arr.Length/2; i++)
    {
        // int vedro = arr[i];
        // arr[i] = arr[size - i];
        // arr[size - i] = vedro;

        (arr[i],arr[size-i])=(arr[size-i],arr[i]);
    }

    return arr;
}

int[]myArray = MassNums(9,1,10);
Print(myArray);

arrRev(myArray);
Print(myArray);
 int [] arr = new int [12];
Random random = new Random();
void arrRandom(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(-9,9);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

void PozNeg(int []arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]=arr[i]*-1} ");
    }
    
}

arrRandom(arr);
PozNeg(arr);

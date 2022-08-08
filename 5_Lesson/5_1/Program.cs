// 
int [] arr = new int [12];
Random random = new Random();
void arrRandomPos(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1,9);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

void Neg(int []arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]=arr[i]*-1} ");
    }
    
}

arrRandomPos(arr);
Neg(arr);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Write a number");
string number = Console.ReadLine();

void sumNumber(string number)
{
    
    int[] myArray = new int [number.Length]; 
    for(int i=0;i<myArray.Length;i++)
    {
        char myChar = number[i];
        string myString = myChar.ToString();
        int myInt = int.Parse(myString);
        myArray[i] = myInt; 
    }
    
    int all_sum=0;

    for(int i =0;i<myArray.Length;i++)
    {
        all_sum=all_sum + myArray[i];
    }
    Console.WriteLine($"Сумма чисел {all_sum}");
}

sumNumber(number);

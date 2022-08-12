// 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Counter()
{
    int count =0;
    for (int i = 0;; i++)
    {
        string num = Console.ReadLine();
        if(num == "")break;
        if(Convert.ToInt32(num)<=0)continue;
        else count++;
    }
    return count;
}

Console.WriteLine("Input number");
Console.WriteLine(Counter());
Console.WriteLine("Введите номер дня недели: ");
int a=int.Parse(Console.ReadLine());

if(a==1)
{
  Console.WriteLine("ПН");  
}
else if(a==2)
    {
        Console.WriteLine("ВТ");
    }
else if(a==3)
    {
        Console.WriteLine("СР");
    }
else if(a==4)
    {
        Console.WriteLine("ЧТ");
    }
else if(a==5)
    {
        Console.WriteLine("ПТ");
    }
else if(a==6)
    {
        Console.WriteLine("СБ");
    }
else if(a==7)
    {
        Console.WriteLine("ВС");
    }
else
    {
        Console.WriteLine("Такого дня недели нет");
    }
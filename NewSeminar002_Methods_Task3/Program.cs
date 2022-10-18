Console.Clear();

void Comparison (int number)
{  
    if (number % 7 == 0 & number % 23 == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        Console.Write("Некратное");
    }
}
Comparison(46);
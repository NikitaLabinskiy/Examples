Console.Clear();

void Comparison (int firstNumber, int secondNumber)
{
    // Console.Write("Введите два числа");
    // firstNumber = Convert.ToInt32(Console.ReadLine());
    // secondNumber = Convert.ToInt32(Console.ReadLine());
   

    if (firstNumber % 2 == 0 & secondNumber % 2 == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        Console.Write("Некратное, остаток ");
        Console.Write(firstNumber % secondNumber);
    }
}
Comparison(16, 6);
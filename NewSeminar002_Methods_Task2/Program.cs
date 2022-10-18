Console.Clear();

void Comparison (int firstNumber, int secondNumber)
{
    // Console.Write("Введите два числа");
    // firstNumber = Convert.ToInt32(Console.ReadLine());
    // secondNumber = Convert.ToInt32(Console.ReadLine());
   

    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        Console.Write("Некратное, остаток ");
        Console.Write(firstNumber % secondNumber);
    }
}
Comparison(35, 4);
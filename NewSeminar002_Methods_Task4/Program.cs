Console.Clear();

void Comparison (int firstNumber, int secondNumber)
{
    int squareFirst = firstNumber * firstNumber;
    int squareSecond = secondNumber * secondNumber;

    if (squareFirst == secondNumber | squareSecond == firstNumber)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
Comparison(25, 625);
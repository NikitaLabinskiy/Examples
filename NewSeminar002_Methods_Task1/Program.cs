Console.Clear();

int GetRandomNumber(int minValue, int maxValue)
{
    int randomNumber = new Random().Next(minValue, maxValue);
    return randomNumber;
}


int DeletesecondDigit(int number)
{
    int lastDigit = number % 10;
    number = number / 100;
    int resault = number * 10 + lastDigit;
    return resault;
}

int something = GetRandomNumber(100, 1000);

Console.WriteLine(something);

int something2 = DeletesecondDigit(something);

Console.WriteLine(something2);
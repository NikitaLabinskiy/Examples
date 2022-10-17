Console.Clear();

int GetRandomNumber(int minValue, int maxValue)
{
    int randomNumber = new Random().Next(minValue, maxValue);
    return randomNumber;
}


int FindMaxWalue(int number)
{
    int max = number % 10;
    number = number / 10;

   while (number > 0)
   {
      int lastNumber = number % 10;
      if(lastNumber > max)
      {
         max = lastNumber;
      }
      number /= 10;
   }
   return max;
}

int searchNumber = GetRandomNumber(10, 1000);

Console.WriteLine(searchNumber);

int maxValue = FindMaxWalue(searchNumber);

Console.WriteLine(maxValue);
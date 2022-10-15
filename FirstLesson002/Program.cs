Console.Clear();
//Console.Write("Введите число ");

//int N = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(N % 10);

Console.Write("Введите два числа: ");

int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = Convert.ToInt32(Console.ReadLine());

int square = NumberA * NumberA;

if (square == NumberB)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
﻿Console.Clear();
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int count = -N;
while (count < N)
{
    Console.Write(count);
    Console.Write(", ");
    count++;
}
Console.Write(count);
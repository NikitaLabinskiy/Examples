Console.Clear();

int[] array = new int[5];
int number = 12345;

if (number > 100 & number < 999)
{
    for(int i = 0; i < array.Length; i++)
    {
        int lastValue = number % 10;
        array[i] = lastValue;

        number /= 10;
    }
}

// for( int i = array.Lanth - 1; i >= 0; i--)
// {
//     Console.Write(array[i]);
// }

// void Reversal (int[] newArray)
// {
//     for (int i = 0; i = array.Length / 2; i++)
//     {
//         int help = 0;
//         help = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = help;
//     }
// }



void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.WriteLine(", ");
        position++;
    }
}


PrintArray(array);









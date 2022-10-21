Console.Clear();

// int[] array = new int[3];
int number = 867665;


while(number > 999 | number < 100)
{
    if(number > 999)
    {
        number /= 10;
    }
    if(number < 100)
    {
        Console.Write("Третьей цифры нет!");
        break;
    }
    if (number < 999 & number >= 100)
    {
        Console.Write(number % 10);
    }
}

// if (number > 999)
// {
//     while(number > 999)
//     {
//         number /= 10;
//     }
// }
//  else
// {
//     if (number >= 100)
//    {
//         number = number % 10;
//         Console.WriteLine(number);
//    } 
//    else
//    {
//         Console.WriteLine("числа нет");
//    }
// }


// Console.WriteLine(number);

// for(int i = 0; i < array.Length; i++)
// {
//     int lastValue = number % 10;
//     array[i] = lastValue;

//     number /= 10;
// }

// Console.WriteLine(array[0]);

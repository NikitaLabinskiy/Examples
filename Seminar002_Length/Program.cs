Console.Clear();

//              0   1   2    3   4   5   6   7   8
int[] array = { 1, 23, 34, 53, 255, 63, 53, 95, 34, 25 };

int n = array.Length;

int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Write(index);
        break;
    }
    index++;
} 

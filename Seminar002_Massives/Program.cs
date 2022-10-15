Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if(arg2 > resault) resault = arg2;
    if(arg3 > resault) resault = arg3;
    return resault;
}
//              0   1   2    3   4   5   6   7   8
int[] array = { 1, 23, 53, 255, 63, 53, 95, 34, 25 };


int resault = Max(Max(array[0], array[1], array[2]), 
               Max(array[3], array[4], array[5]), 
               Max(array[6], array[7], array[8]));

Console.Write(resault);
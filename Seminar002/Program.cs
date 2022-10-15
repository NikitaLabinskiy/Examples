Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if(arg2 > resault) resault = arg2;
    if(arg3 > resault) resault = arg3;
    return resault;
}

int a1 = 12;
int b1 = 23;
int c1 = 1224;
int a2 = 13552;
int b2 = 33;
int c2 = 52;
int a3 = 1444462;
int b3 = 331;
int c3 = 82;

int max = a1;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max4 = Max(max1, max2, max3);

int max4 = Max(Max(a1, b1, c1), 
               Max(a2, b2, c2), 
               Max(a3, b3, c3));

Console.Write(max4);

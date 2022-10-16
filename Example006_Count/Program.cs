int Max(int arg1, )

int a = 1;
int b = 2;
int c = 12;
int d = 8;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("Max = ");
Console.WriteLine(max);
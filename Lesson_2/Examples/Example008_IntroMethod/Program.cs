int Max(int a, int b, int c)
{
    int maximum = a;
    if (b > maximum) maximum = b;
    if (c > maximum) maximum = c;
    return maximum;
}
int a1 = 112125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2),Max(a3, b3, c3));
Console.WriteLine(max);
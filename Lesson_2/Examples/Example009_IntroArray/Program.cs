int Max(int a, int b, int c)
{
    int maximum = a;
    if (b > maximum) maximum = b;
    if (c > maximum) maximum = c;
    return maximum;
}
int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
int max = Max(Max(array[0], array[1], array[2]), 
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8]));
Console.WriteLine(max);

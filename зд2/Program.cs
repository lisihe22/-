
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 5;
int b1 = 7;
int a2 = 2;
int b2 = 10;
int a3 = -9;
int b3 = -3;

int max1 = Max(a1, b1);
int max2 = Max(a2, b2);
int max3 = Max(a3, b3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
// Что то совсем ничего не получается тяжело идут коды попробовала как в лекции но увы
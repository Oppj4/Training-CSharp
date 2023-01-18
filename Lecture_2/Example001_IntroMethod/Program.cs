int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;

    return result;
}

int a1 = 1534343, b1 = 21, c1 = 39,
    a2 = 12, b2 = 2223, c2 = 33,
    a3 = 13, b3 = 23, c3 = 331;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
);
// Тоже самое что и: 
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

Console.WriteLine(max);    
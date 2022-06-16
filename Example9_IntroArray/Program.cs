
int Max(int number1, int number2, int number3)
{
    int result = number1;
    if (number2 > result) result = number2;
    if (number3 > result) result = number3;
    return result;
}

int[] = {31,20,43,74,25,66,73,568,119};

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write("Max number is ");
Console.Write(max);
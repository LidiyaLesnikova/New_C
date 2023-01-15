int Max(int num1,int num2,int num3)
{
    int rezult = num1;
    if (num2>rezult) rezult = num2;
    if (num3>rezult) rezult = num3;
    return rezult;
}

//             0 1 2 3  4 5 6 7  8
int[] array = {5,6,8,95,2,5,6,10,56};

int max = Max(Max(array[0],array[1],array[2]),
              Max(array[3],array[4],array[5]),
              Max(array[6],array[7],array[8]));

Console.WriteLine("max = " + max);
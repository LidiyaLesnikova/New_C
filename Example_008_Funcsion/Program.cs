int Max(int num1,int num2,int num3)
{
    int rezult = num1;
    if (num2>rezult) rezult = num2;
    if (num3>rezult) rezult = num3;
    return rezult;
}

int number1 = new Random().Next(1, 10);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);
int number3 = new Random().Next(1, 10);
Console.WriteLine(number3);
int number4 = new Random().Next(1, 10);
Console.WriteLine(number4);
int number5 = new Random().Next(1, 10);
Console.WriteLine(number5);
int number6 = new Random().Next(1, 10);
Console.WriteLine(number6);
int number7 = new Random().Next(1, 10);
Console.WriteLine(number7);
int number8 = new Random().Next(1, 10);
Console.WriteLine(number8);
int number9 = new Random().Next(1, 10);
Console.WriteLine(number9);

int max1 = Max(number1,number2,number3);
int max2 = Max(number4,number5,number6);
int max3 = Max(number7,number8,number9);
int max = Max(max1,max2,max3);

Console.WriteLine("max = " + max);
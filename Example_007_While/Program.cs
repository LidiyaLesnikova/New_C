Console.Clear();
int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yс = 20;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yс);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;
int what = 0;
while (count<10000)
{
    what = new Random().Next(0, 3);
    //Console.WriteLine(what);
    if (what==0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (what==1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (what==2)
    {
        x = (x+xc)/2;
        y = (y+yс)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count+1;
}
//Console.WriteLine("Все");
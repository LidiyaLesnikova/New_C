//вывод чисел от а до б
string NumbersFor(int a, int b)
{
    string rezult = string.Empty;
    for (int i = a; i <= b; i++)
    {
        rezult += $"{i} ";
    }
    return rezult;
}
string NumbersRec(int a, int b)
{
    if (a<b) return $"{a} " + NumbersRec(a+1, b);
    else return $"{b}";
}

//обратный вывод чисел от б до а
string NumbersFor1(int a, int b)
{
    string rezult = string.Empty;
    for (int i = b; i >= a; i--)
    {
        rezult += $"{i} ";
    }
    return rezult;
}
string NumbersRec1(int a, int b)
{
    if (a<=b) return NumbersRec1(a+1, b) + $"{a} ";
    else return string.Empty;
}

//вывод суммы чисел от 1 до n
int SumFor(int n)
{
    int rezult = 0;
    for (int i = 1; i <= n; i++) rezult += i;
    return rezult;
}
int SumRec(int n)
{
    if (n==0) return 0;
    else return n+SumRec(n-1);
}

//Факториал числа
int FactorialFor(int n)
{
    int rezult = 1;
    for (int i = 1; i <= n; i++) rezult *= i;
    return rezult;
}
int FactorialRec(int n)
{
    if (n==1) return 1;
    else return n*FactorialRec(n-1);
}

//а в степени n 
int PowerFor(int a, int n)
{
    int rezult = 1;
    for (int i = 1; i <= n; i++) rezult *= a;
    return rezult;
}
int PowerRec(int a, int n)
{
    if (n==0) return 1;
    else return a*PowerRec(a, n-1);
}
int PowerRecMath(int a, int n)
{
    if (n==0) return 1;
    else if (n%2==0) return PowerRecMath(a*a, n/2);
    else return a*PowerRecMath(a, n-1);
}

//перебор слов
int n=1;
void Slova(string s, char[] word, int length = 0)
{
    if (length==word.Length)
    {
        Console.WriteLine($"{n++,6} {new String(word)}");
        return;
    }
    for (int i = 0; i < s.Length; i++)
    {
        word[length]=s[i];
        Slova(s, word, length+1);
    }    
}

//Вывод содержимого указанной папки
void CatalogInfo(string path, string otstup="")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{otstup}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, otstup+" ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{otstup}{files[i].Name}");
    }
}

//пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
//     with-1-ая палка (c), on-3-я куда, some-2-я средняя, count-кол-во блинов
{
    if (count>1) Towers(with, some, on, count-1);
    Console.WriteLine($"{with} >> {on}");
    if (count>1) Towers(some, on, with, count-1);
}

//обход "деревьев"
//(( 4 - 2 ) * ( 1 + 3 )) / (10)
//   | | |   |   | | |    1  |       - 1уровень
//   | | |   2   | | |       3       - 2уровень
//   | 4 |       | 5 |      6 7      - 3уровень
//   8   9      10   11              - 4уровень
string emp = string.Empty;
string[] tree = {emp,"/","*","10","-","+",emp,emp,"4","2","1","3"};
//                0   1   2    3   4   5   6   7   8   9  10  11
void InOrderTravelsal(int pos = 1)
{
    if (pos<tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTravelsal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTravelsal(right);

    }
}

Console.WriteLine(NumbersFor(1, 10)); //вывод чисел от а до б
Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine(NumbersFor1(1, 10)); //обратный вывод чисел от б до а
Console.WriteLine(NumbersRec1(1, 10));
Console.WriteLine(SumFor(10)); //вывод суммы чисел от 1 до n
Console.WriteLine(SumRec(10));
Console.WriteLine(FactorialFor(10)); //Факториал числа
Console.WriteLine(FactorialRec(10));
Console.WriteLine(PowerFor(2, 10));//а в степени n
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
Slova("аисв", new char[3]); //перебор слов из 5 букв
string path = @"C:\Users\HOME\Documents\GIT\Examples\New_C\Example_001_HU";
CatalogInfo(path);//Вывод содержимого указанной папки
Towers();//пирамидки
InOrderTravelsal(); //обход "деревьев"
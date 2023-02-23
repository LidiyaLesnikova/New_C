// дано число N, нужно показать от -N до N

int GetValueByUser(string text)
{
    int value = 0;
    bool flag = false;
    do
    {
        Console.Write(text);
        string s = Console.ReadLine()!;
        flag = int.TryParse(s, out value) && value >= 0;
        text = "ошибка ввода, введите заново: ";
    } while (!flag);
    return value;
}

void PrintNumber1(int n)
{
    for (int i = -n; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
}

string PrintNumber2(int n)
{
    string output = string.Empty;
    for (int i = -n; i <= n; i++)
    {
        output += $"{i} ";
    }
    return output;
}

string PrintNumber3(int n)
{
    string output = "0";
    for (int i = 1; i <= n; i++)
    {
        output = $"{-i} " + output + $" {i}";
    }
    return output;
}

int N = GetValueByUser("Введите число N: ");
PrintNumber1(N);
Console.WriteLine();
string rez = PrintNumber3(N);
Console.WriteLine(rez);
File.WriteAllText("data.txt", rez);

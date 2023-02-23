// массив всего элементов array n = 50
// подмассив m =3

int[] GetRangeSum(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n-m+1];

    // int index = 0;
    // for (int i = 0; i <= n-m; i++)
    // {
    //     for (int j = i; j < i+m; j++)
    //     {
    //         t[index] += array[j];
    //     }
    //     index++;
    // }
    for (int i = 0; i < m; i++) t[0] += array[i];
    for (int i = 1; i <= n-m; i++) t[i] = t[i-1] - array[i-1] + array[i+m-1];
    return t;
}

int[] CreateArray(int size) => new int[size];

string Print(int[] array) => $"[{String.Join(", ", array)}]";

void Fill(ref int[] array) => array = array.Select(e=>Random.Shared.Next(10)).ToArray();

int[] numbers = CreateArray(10);
Fill(ref numbers);
Console.WriteLine(Print(numbers));

int count = 3;
int[] group = GetRangeSum(numbers, count);
Console.WriteLine(Print(group));
Console.WriteLine("+");
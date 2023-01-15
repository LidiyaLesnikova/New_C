void FillArray(int[] collection)
{
    int leght = collection.Length;
    int index = 0;
    while (index<leght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(coll[position]+"; ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int n = collection.Length;
    int index = 0;
    int pozition = -1;
    while (index<n)
    {
        if (collection[index]== find) 
        {
            pozition = index;
            break;
        }
        index++; 
    }
    return pozition;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Введите, позицию какого числа надо найти:");
int find = Convert.ToInt32(Console.ReadLine());
int pos = IndexOf(array, find);
if (pos==-1) Console.WriteLine("Число в массиве не найдено");
else Console.WriteLine("Первая позиция искомого числа - "+pos);
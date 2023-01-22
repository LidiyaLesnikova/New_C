int[] array = { 1, 3, 5, 6, 9, 7, 9, 5, 2, 6 };
Console.WriteLine("Введите 1, если массив упорядочить по возрастанию или 0 по убыванию");
int vers = Convert.ToInt32(Console.ReadLine());
if (vers<0||vers>1) Console.WriteLine("Введено неверное значение!!!");
else
{
    PrintArray(array);
    Console.WriteLine();
    SelectArray(array, vers);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine(PrintData());
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
}

void SelectArray(int[] arr, int version)
{
    for (int i = 0; i < arr.Length-1; i++) 
    {
        int minposition = i;
        for (int j = i+1; j < arr.Length; j++)
        {
            if (vers==1)
            {
                if (arr[j]<arr[minposition]) minposition = j;
            }
            else if (arr[j]>arr[minposition]) minposition = j;
        }
        int temp = arr[i];
        arr[i] = arr[minposition];
        arr[minposition] = temp;
    }
}

DateTime PrintData() 
{
    return DateTime.Now;
}
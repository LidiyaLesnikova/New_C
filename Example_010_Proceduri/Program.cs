//             0 1 2 3  4 5 6 7  8  9  10  11 12
int[] array = {5,6,8,95,2,5,6,10,56,54,101,89,54};
int n = array.Length; //длина массива
Console.WriteLine("Введите, позицию какого числа надо найти");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;
while (index<n)
{
    if (array[index]== find) 
    {
        Console.WriteLine("Первая позиция искомого числа - "+index);
        break;
    }
    index++; 
}
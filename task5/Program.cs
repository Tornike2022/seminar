void FillArray(int[] collection) // адаптированная, с использованием метода
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
        
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index<count)
    {
        if (collection[index]==find)
        {
            position=index;
            break;

        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //определили массив из 10 элементов

FillArray(array); //заполнили массив
PrintArray(array); //распечатал
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
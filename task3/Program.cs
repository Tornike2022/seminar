int[] array = {1, 6, 3, 13, 86, 4, 75, 44, 3, 90};
int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
    //index= index+1
}

﻿// программу, которая выводит массив из 8 элементов, 
// заполн 0 и 1 в случ порядке


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
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
int[] array = new int[8]; //определили массив из 8 элементов

FillArray(array); //заполнили массив
PrintArray(array); //распечатал
int Max(int arg1, int arg2, int arg3)

{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int[] array = {12, 7, 78, 90, 55, 32, 12, 98};
array [0] = 6;


Console.WriteLine(array[0]);

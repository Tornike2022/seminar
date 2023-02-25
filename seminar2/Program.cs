// программу кот принимает на вход число и выдает кол-во цифр в числе

Console.Clear();
Console.Write("введите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"количество цифр = {CountNaumbers(s)}");
int CountNaumbers(int n) //123
{
    int count = 0; // count 0
    if (n<0)
        n*= (-1); //n=n*(-1)
    while (n>0) // 0>0
    {
        n/=10; //n=n/10   n=0
        count ++; //count 3
    }
    return count;

}
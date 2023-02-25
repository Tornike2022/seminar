// принимает на вход число а и выдает сумму чисел от 1 до а
int GetSum(int N){
    int sum = 0;
    for (int i = 1; i <= N; i++)
        sum+=i;
    return sum;
}
Console.Clear();
Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine());
// GetSum(n);
Console.WriteLine($"Сумма от 1 до {N} равна {GetSum(N)}");
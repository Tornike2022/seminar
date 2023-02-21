// принимает на вход число N, и выдает таблицу кубов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
Console.Clear();
Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] mas = new int [N]; // int [mas] - массив из целых чисел
for (int i = 1; i<=N; i++)
    mas[i - 1] = i * i * i;
for (int i = 0; i<N; i++)
    Console.WriteLine($"{mas[i]}");

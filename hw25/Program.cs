//напишите цикл, кот принимает на вход 2 числа 
//а и в и возводит число а в натур степень в (3,5 -> 243)
Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{Math.Pow(a, b)}");
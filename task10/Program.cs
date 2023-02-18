//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
int a1 = a/10; 
int a2 = a1%10; 

Console.WriteLine($"second digit of {a} -> {a2}");

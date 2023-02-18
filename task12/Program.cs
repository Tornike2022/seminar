// Напишите программу, которая принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным. 6 -> да
Console.Clear();

Console.WriteLine("введите цифру, обозначающую день недели: ");
int a = int.Parse(Console.ReadLine());
if (a == 1) {Console.WriteLine($"{a} -> нет");}
else if (a == 2) {Console.WriteLine($"{a} -> нет");}
else if (a == 3) {Console.WriteLine($"{a} -> нет");}
else if (a == 4) {Console.WriteLine($"{a} -> нет");}
else if (a == 5) {Console.WriteLine($"{a} -> нет");}
else if (a == 6) {Console.WriteLine($"{a} -> да");}
else if (a == 7) {Console.WriteLine($"{a} -> да");}


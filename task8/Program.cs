//напишите программу, кторая будет принимать на вход 
//два числа и выводить является ли второе число кратным 
//первому. Если второе число не кратно числу первому, 
//то программа выводит остаток от деления.
Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("кратно");

}

else
{
    Console.WriteLine($"не кратно, остаток {a % b}");
}





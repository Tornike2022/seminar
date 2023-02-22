// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
Console.WriteLine("введите пятизначное число");
string n = Console.ReadLine();
string r = string.Concat(n.Reverse());
if (n==r)
{
    Console.WriteLine("палиндром");
}

else
{
    Console.WriteLine("не палиндром");
}

    
    
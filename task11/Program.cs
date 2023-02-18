//Напишите программу, которая выводит третью цифру заданного числа , 
//или сообщает, что третьей цифры нет
Console.Write("a: ");
string a = Console.ReadLine();
if (a.Length==3)
{
    Console.WriteLine(a.Substring(2));

}

else
{
    Console.WriteLine("нет третьей цифры");
}

//принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
Console.Write("a: ");
int a = int.Parse(Console.ReadLine());

if (a % (7*23) == 0)
{
    Console.WriteLine("кратно");

}

else
{
    Console.WriteLine("не кратно");
}

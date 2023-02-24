// Вид 1 - ничего не принимают и ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");

}
// как вызвать такой метод
Method1();

// Вид 2 - ничего не возвращают, но в то же время могут принимать 
//какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Text of the message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("text", 4); // text 4 раза
// Method21(msg:"text", count: 4);
Method21(count: 4, msg:"new text");// new text 4 раза
//3 вид - что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);// выводит год
//4 вид - что-то возвращают, и что-то принимают
string Method4(int count, string text) //строчку с компонуем друг за дружкой count раз

{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res); //получаем asdf 10 раз


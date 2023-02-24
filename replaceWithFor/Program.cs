// дан текст. в тексте нужно все пробелы заменить черточками, маленькие 
// буквы к заменить большими К а большие С заменить маленькими с

string text = "В выходной файл OUTPUT.TXT для запросов get, rsq и rmq" 
+ "выведите результат в отдельной строке в порядке их следования."
+ "Сегодня мы углубимся в тему и выделим 4 основных группы методов, а также будем использовать их на практике" 
+ "И познакомимся с новыми языковыми конструкциями, в частности, циклом.";
// string s = "qwerty"
//             012345
// s[3] // r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result= result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText); //все пробелы в тексте заменились на '|'
Console.WriteLine();//раздел строки
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);//заменили мал к на большую

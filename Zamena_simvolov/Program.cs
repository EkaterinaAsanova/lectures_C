// Работа с текстом 
// Дан текст в нем нужно все пробелы заменить черточками. Маленькие к заменить на большие К


string text = "Князь кот морковка любил коротать время с книжкой";
string Replace(string text, char oldValue, char newValue)
{
string result = string.Empty;
int length = text.Length;
for (int i=0; i < length; i++)
{
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
}
return result;
}
string newText=Replace(text, ' ' , '|');
Console.WriteLine (newText);
Console.WriteLine ();
newText=Replace(newText, 'к' , 'К');
Console.WriteLine (newText);
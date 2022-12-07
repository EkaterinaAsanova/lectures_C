// 1 Вид


void Method1();
{
    Console.WriteLine ("Автор ...");
}
Method1();  //  Вывоз метода(1). Метод не принимает и не выдают параметры


// 2 Вид  Не возвращают, но принимают данные

void Method2(string msg)
{
    Console.WriteLine(msg);

}
 Method2(msg: "Текст сообщения");

void Method2_1(string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1(msg: "Текcт", count: 4);
Method2_1(count: 4, msg:"новый текст");

// 3 Вид не принимают, но возвращает значение

int Metod3()
{
    return DataTime.Now.Year;
}
int yaer = Metod3();
Console.WriteLine(yaer);

// 4 вид. Метод принимает и выдает аргументы

string Method4 (int count,string text)
    int i=0;
    string result = string.Empty; // пустая строка 

while (i< count)
{
    result = result+text;
    i++; 
    return result;
}
string res = Method4 (10, "asdf");
Console.WriteLine(res);


/*Методы, которые ничего не примнимают и не возвращают*/
void Method1()
{
    Console.WriteLine("Автор...");
}
//Как вызываются подобного рода методы
Method1();

/*Методы, которые ничего не возвращают, но могут
принимать какие-то аргументы*/
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); //тут msg - именованный аргумент

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст");//Не имеет значение порядок именованных аргументов

/*Методы, которые что-то возвращают, но ничего не принимают*/
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();//Сюда будет положен результат работы метода
Console.WriteLine(year);

/*Методы, которые что-то принимают и что-то возвращают*/
int Method4(int count, string text)
{
    int i = 0;
    sttring result = string.Empty;
    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
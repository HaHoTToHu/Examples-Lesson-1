//НАРИСУЕМ ТРЕУГОЛЬНИК. АЛГОРИТМ.
//1. Определить три точки
//2. Выбрать две любые
//3. Найти середину
//4. Поставить точку
//5. Выбрать случайную вершину треугольника
//6. Соединить её с полученной на 4 шаге точкой
//7. Перейти к шагу 3
//8. Шаги 3-7 повторить 9, 28, 31, 10000 раз

Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

//Определяем вершины треугольника
int xa = 35, ya = 1,
    xb = 1, yb = 30,
    xc = 70, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 10;

count = 0;

while (count < 10000)
{
    int what = new Random().Next(0,3);
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
        if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
        if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count ++;
}
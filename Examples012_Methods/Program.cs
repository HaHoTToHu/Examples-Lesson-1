// /*Методы, которые ничего не примнимают и не возвращают*/
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// //Как вызываются подобного рода методы
// Method1();

// /*Методы, которые ничего не возвращают, но могут
// принимать какие-то аргументы*/
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения"); //тут msg - именованный аргумент

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Новый текст");//Не имеет значение порядок именованных аргументов

// /*Методы, которые что-то возвращают, но ничего не принимают*/
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();//Сюда будет положен результат работы метода
// Console.WriteLine(year);

// /*Методы, которые что-то принимают и что-то возвращают*/
// int Method4(int count, string text)
// {
//     int i = 0;
//     sttring result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


// /* Цикл for*/
// int Method41(int count, string text)
// {
//     int i = 0;
//     sttring result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method41(10, "z");
// Console.WriteLine(res);

/*Вывод таблицы умножения на экран*/
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

/*Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "C" заменить маленькими "с".*/

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
//s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'В', 'в');
// Console.WriteLine(newText);

/*Сотртировка массива*/
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// //Вывод массива на экран
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");        
//     }
//     Console.WriteLine();
// }

// //Метод, который упорядочивает массив
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i; //Определяем позицию, на которую смотрим
//         //Ищем максимальный элемент (цикл for)
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i]; //Поменять значение нашей минимальной позиции с той позицией, которую мы нашли
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;

//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);